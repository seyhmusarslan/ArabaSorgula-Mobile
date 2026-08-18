namespace ArabaSorgula.Mobile.Controls;

public sealed class ASIconText : ContentView
{
    private readonly Label _iconLabel;
    private readonly Label _textLabel;
    private readonly Grid _layout;

    public static readonly BindableProperty TextProperty = BindableProperty.Create(
        nameof(Text), typeof(string), typeof(ASIconText), string.Empty,
        propertyChanged: OnVisualPropertyChanged);

    public static readonly BindableProperty GlyphProperty = BindableProperty.Create(
        nameof(Glyph), typeof(string), typeof(ASIconText), string.Empty,
        propertyChanged: OnVisualPropertyChanged);

    public static readonly BindableProperty IconColorProperty = BindableProperty.Create(
        nameof(IconColor), typeof(Color), typeof(ASIconText), default(Color),
        propertyChanged: OnVisualPropertyChanged);

    public static readonly BindableProperty TextColorProperty = BindableProperty.Create(
        nameof(TextColor), typeof(Color), typeof(ASIconText), default(Color),
        propertyChanged: OnVisualPropertyChanged);

    public static readonly BindableProperty IconSizeProperty = BindableProperty.Create(
        nameof(IconSize), typeof(double), typeof(ASIconText), 0d,
        propertyChanged: OnVisualPropertyChanged);

    public static readonly BindableProperty SpacingProperty = BindableProperty.Create(
        nameof(Spacing), typeof(double), typeof(ASIconText), 0d,
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

    public ASIconText()
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
            LineBreakMode = LineBreakMode.WordWrap,
            VerticalTextAlignment = TextAlignment.Center
        };
        _textLabel.SetDynamicResource(Label.FontFamilyProperty, "AS.Type.FontFamily.Primary");
        _textLabel.SetDynamicResource(Label.FontSizeProperty, "AS.Type.Body");
        AutomationProperties.SetIsInAccessibleTree(_textLabel, false);

        _layout = new Grid
        {
            HorizontalOptions = LayoutOptions.Fill,
            VerticalOptions = LayoutOptions.Center
        };
        _layout.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
        _layout.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
        Grid.SetColumn(_textLabel, 1);
        _layout.Children.Add(_iconLabel);
        _layout.Children.Add(_textLabel);
        Content = _layout;

        UpdateVisual();
    }

    private static void OnVisualPropertyChanged(BindableObject bindable, object oldValue, object newValue) =>
        ((ASIconText)bindable).UpdateVisual();

    private void UpdateVisual()
    {
        if (_iconLabel is null)
        {
            return;
        }

        _iconLabel.Text = Glyph;
        _iconLabel.IsVisible = !string.IsNullOrEmpty(Glyph);
        _textLabel.Text = Text;

        ApplyColor(_iconLabel, Label.TextColorProperty, IconColor, "AS.Color.Brand.Primary");
        ApplyColor(_textLabel, Label.TextColorProperty, TextColor, "AS.Color.Text.Primary");

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
            _layout.ColumnSpacing = Spacing;
        }
        else
        {
            _layout.SetDynamicResource(Grid.ColumnSpacingProperty, "AS.Space.Sm");
        }

        SemanticProperties.SetDescription(this, Text);
    }

    private static void ApplyColor(Label label, BindableProperty property, Color? color, string resourceKey)
    {
        if (color is null)
        {
            label.SetDynamicResource(property, resourceKey);
        }
        else
        {
            label.SetValue(property, color);
        }
    }
}
