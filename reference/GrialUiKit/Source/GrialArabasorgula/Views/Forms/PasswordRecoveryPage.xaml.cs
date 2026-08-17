/* [grial-metadata] id: Grial#PasswordRecoveryPage.xaml version: 1.1.6 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class PasswordRecoveryPage : ContentPage
    {
        public PasswordRecoveryPage()
        {
            InitializeComponent();
        }

        private async void OnCloseButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}