/* [grial-metadata] id: Grial#SmartHomeMainViewModel.cs version: 1.0.4 */
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class SmartHomeMainViewModel : ObservableObject
    {
        public SmartHomeMainViewModel(INavigation navigation)
        {
            LoadData();

            // Initialize commands that navigates to rooms page
            ViewAllCommand = new Command(() => navigation.PushAsync(new SmartHomeRoomPage()));
            RoomSelectedCommand = new Command<DashboardRoomItemData>(x => navigation.PushAsync(new SmartHomeRoomPage(x)));
        }

        public ICommand ViewAllCommand { get; }
        public ICommand RoomSelectedCommand { get; }

        public ObservableCollection<MainDashboardItemData> DashBoardCards { get; } = new ObservableCollection<MainDashboardItemData>();
        public ObservableCollection<string> Frequency { get; } = new ObservableCollection<string>();
        public ObservableCollection<DashboardRoomItemData> Rooms { get; } = new ObservableCollection<DashboardRoomItemData>();

        private void LoadData()
        {           
            DashBoardCards.Clear();
            Frequency.Clear();
            Rooms.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "SmartHome.json");
        }
    }
}
