/* [grial-metadata] id: Grial#BrandLogo.xaml version: 1.0.1 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class BrandLogo : ContentView
    {
        public static readonly BindableProperty InvertedProperty =
            BindableProperty.Create(
                nameof(Inverted),
                typeof(bool),
                typeof(BrandLogo),
                defaultValue: true);

        public bool Inverted
        {
            get { return (bool)GetValue(InvertedProperty); }
            set { SetValue(InvertedProperty, value); }
        }

        public static readonly BindableProperty BackgroundGradientProperty =
            BindableProperty.Create(
                nameof(BackgroundGradient),
                typeof(Gradient),
                typeof(BrandLogo),
                defaultValue: null);

        public Gradient BackgroundGradient
        {
            get { return (Gradient)GetValue(BackgroundGradientProperty); }
            set { SetValue(BackgroundGradientProperty, value); }
        }

        public BrandLogo()
        {
            InitializeComponent();
        }
    }
}
