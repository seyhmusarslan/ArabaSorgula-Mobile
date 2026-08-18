using Microsoft.Maui.Controls.Shapes;

namespace ArabaSorgula.Mobile.Controls;

public sealed class ASBadge : ContentView
{
    private readonly Border _border;
    private readonly Label _label;

    public static readonly BindableProperty TextProperty = BindableProperty.Create(
        nameof(Text), typeof(string), typeof(ASBadge), string.Empty,
        propertyChanged: OnVisualPropertyChanged);

    public static readonly BindableProperty TextColorProperty = BindableProperty.Create(
        nameof(TextColor), typeof(Color), typeof(ASBadge), default(Color),
        propertyChanged: OnVisualPropertyChanged);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public Color? TextColor
    {
        get => (Color?)GetValue(TextColorProperty);
        set => SetValue(TextColorProperty, value);
    }

    public ASBadge()
    {
        SetDynamicResource(BackgroundColorProperty, "AS.Color.Brand.Primary");

        _label = new Label
        {
            HorizontalTextAlignment = TextAlignment.Center,
            LineBreakMode = LineBreakMode.NoWrap,
            MaxLines = 1,
            VerticalTextAlignment = TextAlignment.Center
        };
        _label.SetDynamicResource(Label.FontFamilyProperty, "AS.Type.FontFamily.Strong");
        _label.SetDynamicResource(Label.FontSizeProperty, "AS.Type.Caption");
        AutomationProperties.SetIsInAccessibleTree(_label, false);

        var shape = new RoundRectangle();
        shape.SetDynamicResource(RoundRectangle.CornerRadiusProperty, "AS.Radius.Lg");

        _border = new Border
        {
            Content = _label,
            StrokeShape = shape,
            StrokeThickness = 0
        };
        _border.SetBinding(BackgroundColorProperty, new Binding(nameof(BackgroundColor), source: this));
        _border.SetDynamicResource(PaddingProperty, "AS.Inset.Badge");
        Content = _border;

        UpdateVisual();
    }

    private static void OnVisualPropertyChanged(BindableObject bindable, object oldValue, object newValue) =>
        ((ASBadge)bindable).UpdateVisual();

    private void UpdateVisual()
    {
        if (_label is null)
        {
            return;
        }

        _label.Text = Text;
        if (TextColor is null)
        {
            _label.SetDynamicResource(Label.TextColorProperty, "AS.Color.Text.OnBrand");
        }
        else
        {
            _label.TextColor = TextColor;
        }

        SemanticProperties.SetDescription(this, Text);
    }
}
