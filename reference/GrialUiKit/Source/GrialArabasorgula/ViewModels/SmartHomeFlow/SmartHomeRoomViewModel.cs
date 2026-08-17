/* [grial-metadata] id: Grial#SmartHomeRoomViewModel.cs version: 1.2.6 */
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class SmartHomeRoomViewModel : ObservableObject
    {
        private readonly INavigation _navigation;

        public SmartHomeRoomViewModel(INavigation navigation, DashboardRoomItemData room = null)
        {
            _navigation = navigation;

            SelectedRoom = room;

            LoadData();

            ItemTappedCommand = new Command<RoomDeviceItemData>(OnItemTapped);
        }

        public ICommand ItemTappedCommand { get; }

        public DashboardRoomItemData SelectedRoom { get; set; }
        public ObservableCollection<DashboardRoomItemData> Rooms { get; } = new ObservableCollection<DashboardRoomItemData>();
        public ObservableCollection<RoomDeviceItemData> Devices { get; set; } = new ObservableCollection<RoomDeviceItemData>();
        public ObservableCollection<DashboardRoomChartItemData> RecentActivity { get; } = new ObservableCollection<DashboardRoomChartItemData>();

        public string Title { get; set; }

        private void OnItemTapped(RoomDeviceItemData device)
        {
            if (device.IsLamp)
            {
                // Navigate to Light settings page
                _navigation.PushAsync(new SmartHomeLightSettingsPage(device));
            }           
            else if (device.IsAir)
            {
                // Navigate to AC settings page
                _navigation.PushAsync(new SmartHomeAirSettingsPage(device));
            }
            else
            {
                if (Application.Current == null || Application.Current.Windows.Count == 0)
                {
                    return;
                }

                Application.Current?.Windows[0]?.Page.DisplayAlertAsync("Device Tap", "Pick a Light or an AC to see details/settings", Resx.AppResources.StringOK);
            }
        }

        private void LoadData()
        {           
            Rooms.Clear();
            Devices.Clear();
            RecentActivity.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "SmartHome.json");

            if (SelectedRoom != null)
            {
                Devices = new ObservableCollection<RoomDeviceItemData>(Devices.Take(SelectedRoom.DeviceCount));
                Title = SelectedRoom.Name;
            }
            else
            {
                Title = Resx.AppResources.StringHome;
            }
        }
    }
}
