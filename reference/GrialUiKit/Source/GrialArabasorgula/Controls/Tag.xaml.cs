/* [grial-metadata] id: Grial#Tag.xaml version: 1.0.1 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class Tag : ContentView
    {
        public static readonly BindableProperty ImageProperty =
            BindableProperty.Create(
                nameof(Image),
                typeof(ImageSource),
                typeof(Tag),
                defaultValue: null);

        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly BindableProperty ImageSizeProperty =
            BindableProperty.Create(
                nameof(ImageSize),
                typeof(double),
                typeof(Tag),
                defaultValue: 20.0);

        public double ImageSize
        {
            get { return (double)GetValue(ImageSizeProperty); }
            set { SetValue(ImageSizeProperty, value); }
        }

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(
                nameof(TextColor),
                typeof(Color),
                typeof(Tag),
                defaultValue: Colors.White);

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(
                nameof(Text),
                typeof(string),
                typeof(Tag),
                defaultValue: string.Empty);

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly BindableProperty IconProperty =
            BindableProperty.Create(
                nameof(Icon),
                typeof(string),
                typeof(Tag),
                defaultValue: string.Empty);

        public string Icon
        {
            get { return (string)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create(
                nameof(CornerRadius),
                typeof(double),
                typeof(Tag),
                defaultValue: 6.0);

        public double CornerRadius
        {
            get { return (double)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly BindableProperty FontSizeProperty =
            BindableProperty.Create(
                nameof(FontSize),
                typeof(double),
                typeof(Tag),
                defaultValue: 10.0);

        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        public static readonly BindableProperty IconFontSizeProperty =
            BindableProperty.Create(
                nameof(IconFontSize),
                typeof(double),
                typeof(Tag),
                defaultValue: 10.0);

        public double IconFontSize
        {
            get { return (double)GetValue(IconFontSizeProperty); }
            set { SetValue(IconFontSizeProperty, value); }
        }

        public static readonly BindableProperty ImageBorderColorProperty = BindableProperty.Create(
            nameof(ImageBorderColor),
            typeof(Color),
            typeof(Tag),
            Colors.White);

        public Color ImageBorderColor
        {
            get { return (Color)GetValue(ImageBorderColorProperty); }
            set { SetValue(ImageBorderColorProperty, value); }
        }

        public static readonly BindableProperty ImageBorderSizeProperty = BindableProperty.Create(
            nameof(ImageBorderSize),
            typeof(double),
            typeof(Tag),
            0d);

        public double ImageBorderSize
        {
            get { return (double)GetValue(ImageBorderSizeProperty); }
            set { SetValue(ImageBorderSizeProperty, value); }
        }

        public static readonly BindableProperty TextTransformProperty =
            BindableProperty.Create(
                nameof(TextTransform),
                typeof(TextTransform),
                typeof(Tag),
                defaultValue: TextTransform.None);

        public TextTransform TextTransform
        {
            get { return (TextTransform)GetValue(TextTransformProperty); }
            set { SetValue(TextTransformProperty, value); }
        }

        public Tag()
        {
            InitializeComponent();
        }
    }
}