/* [grial-metadata] id: Grial#WizardVariantMainPage.xaml version: 1.1.6 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class WizardVariantMainPage : ContentPage
    {
        public WizardVariantMainPage()
        {
            InitializeComponent();

            BindingContext = new WizardMainViewModel();
        }

        private async void OnClose(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}