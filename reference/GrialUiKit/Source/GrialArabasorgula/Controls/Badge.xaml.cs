/* [grial-metadata] id: Grial#Badge.xaml version: 1.0.1 */
using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls.Shapes;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class Badge : ContentView
    {
        public static readonly BindableProperty AutoHideProperty =
            BindableProperty.Create(
                nameof(AutoHide),
                typeof(bool),
                typeof(Badge),
                defaultValue: true,
                propertyChanged: (b, o, n) => ((Badge)b).UpdateVisibility());

        public bool AutoHide
        {
            get { return (bool)GetValue(AutoHideProperty); }
            set { SetValue(AutoHideProperty, value); }
        }

        public static readonly BindableProperty SizeProperty =
            BindableProperty.Create(
                nameof(Size),
                typeof(double),
                typeof(Badge),
                30d,
                propertyChanged: (b, o, n) => ((Badge)b).UpdateVisual());

        public double Size
        {
            get { return (double)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }

        public static readonly BindableProperty BorderSizeProperty =
            BindableProperty.Create(
                nameof(BorderSize),
                typeof(double),
                typeof(Badge),
                0d,
                propertyChanged: (b, o, n) => ((Badge)b).UpdateVisual());

        public double BorderSize
        {
            get { return (double)GetValue(BorderSizeProperty); }
            set { SetValue(BorderSizeProperty, value); }
        }

        public static readonly new BindableProperty BackgroundColorProperty =
            BindableProperty.Create(
                nameof(BackgroundColor),
                typeof(Color),
                typeof(Badge),
                defaultValue: null);

        public new Color BackgroundColor
        {
            get { return (Color)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }

        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create(
                nameof(BorderColor),
                typeof(Color),
                typeof(Badge),
                null);

        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(
                nameof(Text),
                typeof(string),
                typeof(Badge),
                propertyChanged: (b, o, n) => ((Badge)b).UpdateVisibility());

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(
                nameof(TextColor),
                typeof(Color),
                typeof(Badge),
                null);

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        public static readonly BindableProperty FontFamilyProperty = BindableProperty.Create(
           nameof(FontFamily),
           typeof(string),
           typeof(Badge));

        public string FontFamily
        {
            get { return (string)GetValue(FontFamilyProperty); }
            set { SetValue(FontFamilyProperty, value); }
        }

        public static readonly BindableProperty FontSizeProperty =
            BindableProperty.Create(
                nameof(FontSize),
                typeof(double),
                typeof(Badge),
                11d);

        public static readonly BindableProperty TextTranslationYProperty =
            BindableProperty.Create(
                nameof(TextTranslationY),
                typeof(double),
                typeof(Badge),
                defaultValue: 0d);

        public double TextTranslationY
        {
            get { return (double)GetValue(TextTranslationYProperty); }
            set { SetValue(TextTranslationYProperty, value); }
        }

        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        public Badge()
        {
            InitializeComponent();
        }

        protected override void OnParentSet()
        {
            base.OnParentSet();

            UpdateVisual();
            UpdateVisibility();
        }

        private void UpdateVisual()
        {
            if (indicator == null)
            {
                return;
            }

            if (Size > 0)
            {
                indicator.Margin = BorderSize > 0 ? new Thickness(BorderSize) : new Thickness(0);
                indicator.StrokeShape = new RoundRectangle() { CornerRadius = (float)Size / 2 };
                HeightRequest = Size;
                WidthRequest = Size;
                label.WidthMargin = Size / 3;

                if (BorderSize > 0)
                {
                    border.IsVisible = true;
                    border.HeightRequest = Size + (BorderSize * 2);
                    border.WidthRequest = Size + (BorderSize * 2);
                    border.CornerRadius = (Size + (BorderSize * 2)) / 2;

                    HeightRequest = border.HeightRequest;
                    WidthRequest = border.WidthRequest;
                }
                else
                {
                    border.IsVisible = false;
                }
            }
            else
            {
                border.IsVisible = false;
            }
        }

        private void UpdateVisibility()
        {
            IsVisible = !AutoHide ||
                (!string.IsNullOrWhiteSpace(Text) && Text.Trim() != "0");
        }
    }
}
