/* [grial-metadata] id: Grial#SmartHomeSchedulePopup.xaml version: 1.0.6 */

using UXDivers.Popups.Maui;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class SmartHomeLightSchedulePopup : PopupPage
    {
        public SmartHomeLightSchedulePopup(SmartHomeLightSchedulePopupViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
        }

        private void OnClose(object sender, EventArgs e)
        {
            IPopupService.Current.PopAsync();
        }
    }
}