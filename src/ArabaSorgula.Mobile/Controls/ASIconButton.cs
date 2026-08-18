using System.Windows.Input;
using Microsoft.Maui.Controls.Shapes;

namespace ArabaSorgula.Mobile.Controls;

public sealed class ASIconButton : ContentView
{
    private readonly Border _border;
    private readonly Label _iconLabel;
    private readonly Label _textLabel;
    private readonly HorizontalStackLayout _layout;
    private readonly TapGestureRecognizer _tapGesture;
    private ICommand? _subscribedCommand;

    public static readonly BindableProperty TextProperty = BindableProperty.Create(
        nameof(Text), typeof(string), typeof(ASIconButton), string.Empty,
        propertyChanged: OnVisualPropertyChanged);

    public static readonly BindableProperty GlyphProperty = BindableProperty.Create(
        nameof(Glyph), typeof(string), typeof(ASIconButton), string.Empty,
        propertyChanged: OnVisualPropertyChanged);

    public static readonly BindableProperty SemanticDescriptionProperty = BindableProperty.Create(
        nameof(SemanticDescription), typeof(string), typeof(ASIconButton), string.Empty,
        propertyChanged: OnVisualPropertyChanged);

    public static readonly BindableProperty CommandProperty = BindableProperty.Create(
        nameof(Command), typeof(ICommand), typeof(ASIconButton), default(ICommand),
        propertyChanged: OnCommandChanged);

    public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create(
        nameof(CommandParameter), typeof(object), typeof(ASIconButton), default(object),
        propertyChanged: OnCommandParameterChanged);

    public static readonly BindableProperty IconColorProperty = BindableProperty.Create(
        nameof(IconColor), typeof(Color), typeof(ASIconButton), default(Color),
        propertyChanged: OnVisualPropertyChanged);

    public static readonly BindableProperty TextColorProperty = BindableProperty.Create(
        nameof(TextColor), typeof(Color), typeof(ASIconButton), default(Color),
        propertyChanged: OnVisualPropertyChanged);

    public static readonly BindableProperty IconSizeProperty = BindableProperty.Create(
        nameof(IconSize), typeof(double), typeof(ASIconButton), 0d,
        propertyChanged: OnVisualPropertyChanged);

    public static readonly BindableProperty SpacingProperty = BindableProperty.Create(
        nameof(Spacing), typeof(double), typeof(ASIconButton), 0d,
        propertyChanged: OnVisualPropertyChanged);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public string Glyph
    {
        get => (string)GetValue(GlyphProperty);
        set => SetValue(GlyphProperty, value);
    }

    public string SemanticDescription
    {
        get => (string)GetValue(SemanticDescriptionProperty);
        set => SetValue(SemanticDescriptionProperty, value);
    }

    public ICommand? Command
    {
        get => (ICommand?)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    public object? CommandParameter
    {
        get => GetValue(CommandParameterProperty);
        set => SetValue(CommandParameterProperty, value);
    }

    public Color? IconColor
    {
        get => (Color?)GetValue(IconColorProperty);
        set => SetValue(IconColorProperty, value);
    }

    public Color? TextColor
    {
        get => (Color?)GetValue(TextColorProperty);
        set => SetValue(TextColorProperty, value);
    }

    public double IconSize
    {
        get => (double)GetValue(IconSizeProperty);
        set => SetValue(IconSizeProperty, value);
    }

    public double Spacing
    {
        get => (double)GetValue(SpacingProperty);
        set => SetValue(SpacingProperty, value);
    }

    public ASIconButton()
    {
        _iconLabel = new Label
        {
            HorizontalTextAlignment = TextAlignment.Center,
            VerticalTextAlignment = TextAlignment.Center
        };
        _iconLabel.SetDynamicResource(Label.FontFamilyProperty, "AS.Icon.FontFamily");
        AutomationProperties.SetIsInAccessibleTree(_iconLabel, false);

        _textLabel = new Label
        {
            VerticalTextAlignment = TextAlignment.Center
        };
        _textLabel.SetDynamicResource(Label.FontFamilyProperty, "AS.Type.FontFamily.Strong");
        _textLabel.SetDynamicResource(Label.FontSizeProperty, "AS.Type.BodyStrong");
        AutomationProperties.SetIsInAccessibleTree(_textLabel, false);

        _layout = new HorizontalStackLayout
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
        _layout.Children.Add(_iconLabel);
        _layout.Children.Add(_textLabel);

        var shape = new RoundRectangle();
        shape.SetDynamicResource(RoundRectangle.CornerRadiusProperty, "AS.Radius.Md");

        _border = new Border
        {
            Content = _layout,
            StrokeShape = shape,
            StrokeThickness = 0
        };
        _border.SetDynamicResource(VisualElement.BackgroundColorProperty, "AS.Color.Brand.Primary");
        _border.SetDynamicResource(PaddingProperty, "AS.Inset.Button");

        _tapGesture = new TapGestureRecognizer();
        GestureRecognizers.Add(_tapGesture);
        SetDynamicResource(MinimumHeightRequestProperty, "AS.Size.TouchTarget.Minimum");
        SetDynamicResource(MinimumWidthRequestProperty, "AS.Size.TouchTarget.Minimum");
        Content = _border;

        PropertyChanged += (_, args) =>
        {
            if (args.PropertyName == IsEnabledProperty.PropertyName)
            {
                RefreshCommandAvailability();
            }
        };

        UpdateVisual();
        UpdateCommandSubscription(null, Command);
    }

    private static void OnVisualPropertyChanged(BindableObject bindable, object oldValue, object newValue) =>
        ((ASIconButton)bindable).UpdateVisual();

    private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue) =>
        ((ASIconButton)bindable).UpdateCommandSubscription((ICommand?)oldValue, (ICommand?)newValue);

    private static void OnCommandParameterChanged(BindableObject bindable, object oldValue, object newValue) =>
        ((ASIconButton)bindable).RefreshCommandAvailability();

    private void UpdateVisual()
    {
        if (_iconLabel is null)
        {
            return;
        }

        _iconLabel.Text = Glyph;
        _iconLabel.IsVisible = !string.IsNullOrEmpty(Glyph);
        _textLabel.Text = Text;
        _textLabel.IsVisible = !string.IsNullOrEmpty(Text);

        ApplyColor(_iconLabel, IconColor);
        ApplyColor(_textLabel, TextColor);

        if (IconSize > 0)
        {
            _iconLabel.FontSize = IconSize;
        }
        else
        {
            _iconLabel.SetDynamicResource(Label.FontSizeProperty, "AS.Icon.Size.Md");
        }

        if (Spacing > 0)
        {
            _layout.Spacing = Spacing;
        }
        else
        {
            _layout.SetDynamicResource(StackBase.SpacingProperty, "AS.Space.Sm");
        }

        UpdateSemanticDescription();
    }

    private void UpdateCommandSubscription(ICommand? oldCommand, ICommand? newCommand)
    {
        if (_tapGesture is null)
        {
            return;
        }

        if (oldCommand is not null)
        {
            oldCommand.CanExecuteChanged -= OnCanExecuteChanged;
        }

        if (_subscribedCommand is not null && !ReferenceEquals(_subscribedCommand, oldCommand))
        {
            _subscribedCommand.CanExecuteChanged -= OnCanExecuteChanged;
        }

        _subscribedCommand = newCommand;
        if (_subscribedCommand is not null)
        {
            _subscribedCommand.CanExecuteChanged += OnCanExecuteChanged;
        }

        _tapGesture.CommandParameter = CommandParameter;
        RefreshCommandAvailability();
    }

    private void OnCanExecuteChanged(object? sender, EventArgs e) =>
        RefreshCommandAvailability();

    private void RefreshCommandAvailability()
    {
        if (_tapGesture is null || _border is null)
        {
            return;
        }

        _tapGesture.CommandParameter = CommandParameter;
        var isEffectivelyEnabled = IsEnabled && (Command?.CanExecute(CommandParameter) ?? true);
        _tapGesture.Command = isEffectivelyEnabled ? Command : null;
        _border.Opacity = isEffectivelyEnabled ? 1 : 0.5;
    }

    private void UpdateSemanticDescription()
    {
        var description = string.IsNullOrWhiteSpace(SemanticDescription)
            ? Text
            : SemanticDescription;
        SemanticProperties.SetDescription(this, description);
    }

    private static void ApplyColor(Label label, Color? color)
    {
        if (color is null)
        {
            label.SetDynamicResource(Label.TextColorProperty, "AS.Color.Text.OnBrand");
        }
        else
        {
            label.TextColor = color;
        }
    }
}
