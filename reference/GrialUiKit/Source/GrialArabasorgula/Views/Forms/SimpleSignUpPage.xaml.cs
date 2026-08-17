/* [grial-metadata] id: Grial#SimpleSignUpPage.xaml version: 1.1.6 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class SimpleSignUpPage : ContentPage
    {
        public SimpleSignUpPage()
        {
            InitializeComponent();
        }

        private async void OnCloseButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}
