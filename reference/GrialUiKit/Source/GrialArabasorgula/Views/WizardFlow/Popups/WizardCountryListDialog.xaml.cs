/* [grial-metadata] id: Grial#WizardCountryListDialog.xaml version: 2.0.6 */

using UXDivers.Popups.Maui;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class WizardCountryListDialog : PopupPage
    {
        public WizardCountryListDialog(Action<WizardCountryData> select)
        {
            InitializeComponent();

            BindingContext = new WizardCountryListViewModel(select);
        }

        private void OnClose(object sender, EventArgs e)
        {
            IPopupService.Current.PopAsync();
        }
    }
}