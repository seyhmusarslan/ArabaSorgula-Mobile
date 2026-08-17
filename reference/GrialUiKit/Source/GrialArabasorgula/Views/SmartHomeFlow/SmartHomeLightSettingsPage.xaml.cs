/* [grial-metadata] id: Grial#SmartHomeLightSettingsPage.xaml version: 1.1.4 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class SmartHomeLightSettingsPage : ContentPage
    {
        public SmartHomeLightSettingsPage(RoomDeviceItemData device)
        {
            InitializeComponent();

            BindingContext = new SmartHomeLightSettingsViewModel(device);
        }

        public SmartHomeLightSettingsPage()
        {
            InitializeComponent();

            BindingContext = new SmartHomeLightSettingsViewModel();
        }
    }
}