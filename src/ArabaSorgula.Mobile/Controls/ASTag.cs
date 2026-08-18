using System.Windows.Input;
using ArabaSorgula.Mobile.Resources.Icons;
using Microsoft.Maui.Controls.Shapes;

namespace ArabaSorgula.Mobile.Controls;

public sealed class ASTag : ContentView
{
    private readonly Border _border;
    private readonly Label _selectionIndicator;
    private readonly Label _textLabel;

    public static readonly BindableProperty TextProperty = BindableProperty.Create(
        nameof(Text), typeof(string), typeof(ASTag), string.Empty,
        propertyChanged: OnVisualPropertyChanged);

    public static readonly BindableProperty SemanticDescriptionProperty = BindableProperty.Create(
        nameof(SemanticDescription), typeof(string), typeof(ASTag), string.Empty,
        propertyChanged: OnVisualPropertyChanged);

    public static readonly BindableProperty IsSelectedProperty = BindableProperty.Create(
        nameof(IsSelected), typeof(bool), typeof(ASTag), false,
        defaultBindingMode: BindingMode.TwoWay,
        propertyChanged: OnSelectionChanged);

    public static readonly BindableProperty CommandProperty = BindableProperty.Create(
        nameof(Command), typeof(ICommand), typeof(ASTag), default(ICommand));

    public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create(
        nameof(CommandParameter), typeof(object), typeof(ASTag), default(object));

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public string SemanticDescription
    {
        get => (string)GetValue(SemanticDescriptionProperty);
        set => SetValue(SemanticDescriptionProperty, value);
    }

    public bool IsSelected
    {
        get => (bool)GetValue(IsSelectedProperty);
        set => SetValue(IsSelectedProperty, value);
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

    public event EventHandler? SelectionChanged;

    public ASTag()
    {
        _selectionIndicator = new Label
        {
            HorizontalTextAlignment = TextAlignment.Center,
            Text = GrialIconsFont.Check,
            VerticalTextAlignment = TextAlignment.Center
        };
        _selectionIndicator.SetDynamicResource(Label.FontFamilyProperty, "AS.Icon.FontFamily");
        _selectionIndicator.SetDynamicResource(Label.FontSizeProperty, "AS.Icon.Size.Sm");
        AutomationProperties.SetIsInAccessibleTree(_selectionIndicator, false);

        _textLabel = new Label
        {
            LineBreakMode = LineBreakMode.TailTruncation,
            MaxLines = 1,
            VerticalTextAlignment = TextAlignment.Center
        };
        _textLabel.SetDynamicResource(Label.FontFamilyProperty, "AS.Type.FontFamily.Primary");
        _textLabel.SetDynamicResource(Label.FontSizeProperty, "AS.Type.Caption");
        AutomationProperties.SetIsInAccessibleTree(_textLabel, false);

        var layout = new HorizontalStackLayout
        {
            VerticalOptions = LayoutOptions.Center
        };
        layout.SetDynamicResource(StackBase.SpacingProperty, "AS.Space.Xs");
        layout.Children.Add(_selectionIndicator);
        layout.Children.Add(_textLabel);

        var shape = new RoundRectangle();
        shape.SetDynamicResource(RoundRectangle.CornerRadiusProperty, "AS.Radius.Lg");

        _border = new Border
        {
            Content = layout,
            HorizontalOptions = LayoutOptions.Center,
            StrokeShape = shape,
            StrokeThickness = 1,
            VerticalOptions = LayoutOptions.Center
        };
        _border.SetDynamicResource(PaddingProperty, "AS.Inset.Tag");
        SetDynamicResource(MinimumHeightRequestProperty, "AS.Size.TouchTarget.Minimum");
        SetDynamicResource(MinimumWidthRequestProperty, "AS.Size.TouchTarget.Minimum");
        GestureRecognizers.Add(new TapGestureRecognizer
        {
            Command = new Command(HandleTap)
        });
        Content = _border;

        PropertyChanged += (_, args) =>
        {
            if (args.PropertyName == IsEnabledProperty.PropertyName)
            {
                _border.Opacity = IsEnabled ? 1 : 0.5;
            }
        };

        UpdateVisual();
        UpdateSelection();
    }

    private static void OnVisualPropertyChanged(BindableObject bindable, object oldValue, object newValue) =>
        ((ASTag)bindable).UpdateVisual();

    private static void OnSelectionChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var tag = (ASTag)bindable;
        tag.UpdateSelection();
        tag.UpdateSemanticDescription();
        tag.SelectionChanged?.Invoke(tag, EventArgs.Empty);
    }

    private void HandleTap()
    {
        if (!IsEnabled)
        {
            return;
        }

        IsSelected = !IsSelected;
        if (Command?.CanExecute(CommandParameter) == true)
        {
            Command.Execute(CommandParameter);
        }
    }

    private void UpdateVisual()
    {
        if (_textLabel is null)
        {
            return;
        }

        _textLabel.Text = Text;
        UpdateSemanticDescription();
    }

    private void UpdateSemanticDescription()
    {
        var description = string.IsNullOrWhiteSpace(SemanticDescription)
            ? Text
            : SemanticDescription;
        SemanticProperties.SetDescription(this, description);
    }

    private void UpdateSelection()
    {
        if (_border is null)
        {
            return;
        }

        _selectionIndicator.IsVisible = IsSelected;
        if (IsSelected)
        {
            _border.SetDynamicResource(BackgroundColorProperty, "AS.Color.Brand.Primary");
            _border.SetDynamicResource(Border.StrokeProperty, "AS.Color.Brand.Primary");
            _selectionIndicator.SetDynamicResource(Label.TextColorProperty, "AS.Color.Text.OnBrand");
            _textLabel.SetDynamicResource(Label.TextColorProperty, "AS.Color.Text.OnBrand");
        }
        else
        {
            _border.SetDynamicResource(BackgroundColorProperty, "AS.Color.Surface.Primary");
            _border.SetDynamicResource(Border.StrokeProperty, "AS.Color.Border.Default");
            _textLabel.SetDynamicResource(Label.TextColorProperty, "AS.Color.Text.Primary");
        }
    }
}
