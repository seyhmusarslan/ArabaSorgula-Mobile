/* [grial-metadata] id: Grial#SmartHomeRoomPage.xaml version: 1.0.4 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class SmartHomeRoomPage : ContentPage
    {
        public SmartHomeRoomPage()
        {
            InitializeComponent();

            BindingContext = new SmartHomeRoomViewModel(Navigation);
        }

        public SmartHomeRoomPage(DashboardRoomItemData room)
        {
            InitializeComponent();

            BindingContext = new SmartHomeRoomViewModel(Navigation, room);
        }
    }
}