/* [grial-metadata] id: Grial#WizardMainPage.xaml version: 1.0.3 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class WizardMainPage : ContentPage
    {
        public WizardMainPage()
        {
            InitializeComponent();

            BindingContext = new WizardMainViewModel();
        }
    }
}