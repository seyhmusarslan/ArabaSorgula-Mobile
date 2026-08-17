/* [grial-metadata] id: Grial#FullBackgroundSignupPage.xaml version: 1.1.6 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class FullBackgroundSignupPage : ContentPage
    {
        public FullBackgroundSignupPage()
        {
            InitializeComponent();
        }

        private async void OnCloseButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}
