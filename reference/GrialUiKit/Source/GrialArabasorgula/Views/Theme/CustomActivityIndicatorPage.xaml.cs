/* [grial-metadata] id: Grial#CustomActivityIndicatorPage.xaml version: 1.0.1 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class CustomActivityIndicatorPage : ContentPage
    {
        public CustomActivityIndicatorPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Indicator.Start();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            Indicator.Stop();
        }
    }
}