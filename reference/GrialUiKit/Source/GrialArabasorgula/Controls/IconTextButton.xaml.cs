/* [grial-metadata] id: Grial#IconTextButton.xaml version: 1.1.3 */
using System;
using System.Collections.Generic;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class IconTextButton : ContentView
    {
        public static readonly BindableProperty CommandProperty = BindableProperty.Create(
            nameof(Command),
            typeof(ICommand),
            typeof(IconTextButton),
            defaultValue: null);

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create(
            nameof(CommandParameter),
            typeof(object),
            typeof(IconTextButton),
            defaultValue: null);

        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public static readonly BindableProperty IconProperty = BindableProperty.Create(
           nameof(Icon),
           typeof(string),
           typeof(IconTextButton));

        public string Icon
        {
            get { return (string)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(
           nameof(Text),
           typeof(string),
           typeof(IconTextButton));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly BindableProperty StyleIconTextProperty = BindableProperty.Create(
           nameof(StyleIconText),
           typeof(Style),
           typeof(IconTextButton));

        public Style StyleIconText
        {
            get { return (Style)GetValue(StyleIconTextProperty); }
            set { SetValue(StyleIconTextProperty, value); }
        }

        public static readonly BindableProperty IconTextPaddingProperty = BindableProperty.Create(
           nameof(IconTextPadding),
           typeof(Thickness),
           typeof(IconTextButton));

        public Thickness IconTextPadding
        {
            get { return (Thickness)GetValue(IconTextPaddingProperty); }
            set { SetValue(IconTextPaddingProperty, value); }
        }

        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(
           nameof(BorderColor),
           typeof(Color),
           typeof(IconTextButton));

        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly BindableProperty IconColorProperty = BindableProperty.Create(
           nameof(IconColor),
           typeof(Color),
           typeof(IconTextButton));

        public Color IconColor
        {
            get { return (Color)GetValue(IconColorProperty); }
            set { SetValue(IconColorProperty, value); }
        }

        public IconTextButton()
        {
            InitializeComponent();
        }
    }
}
