/* [grial-metadata] id: Grial#EmptyStatePage.xaml version: 1.0.1 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class EmptyStatePage : ContentPage
    {
        public EmptyStatePage()
        {
            InitializeComponent();
        }

        private async void OnCloseButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopAsync();
        }
    }
}