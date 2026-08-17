/* [grial-metadata] id: Grial#SmartHomeAirSettingsViewModel.cs version: 2.0.6 */

using System.Collections.ObjectModel;
using System.Windows.Input;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
    public class SmartHomeAirSettingsViewModel : ObservableObject
    {
        private AirDevice _selectedDevice;
        private AirSettingsData _selectedAirMode;

        public SmartHomeAirSettingsViewModel(RoomDeviceItemData data = null)
        {
            AddScheduleCommand = new Command(async () => await OnAddScheduleCommand());
            EditScheduleCommand = new Command<AirSchedule>(async (item) => await OnEditScheduleCommand(item));
            DeleteScheduleCommand = new Command<Schedule>(OnDeleteScheduleCommand);

            LoadData();

            SelectedDevice = LoadAir(data);

            AirSpeeds = new ObservableCollection<AirSpeed>(Enum.GetValues(typeof(AirSpeed)) as AirSpeed[]);

            var airmode = AirModes.FirstOrDefault(m => m.Name == SelectedDevice.Mode.ToString());
            SelectedAirMode = airmode;
        }

        public ICommand AddScheduleCommand { get; }
        public ICommand EditScheduleCommand { get; }
        public ICommand DeleteScheduleCommand { get; }

        public AirDevice SelectedDevice
        {
            get { return _selectedDevice; }
            set { SetProperty(ref _selectedDevice, value); }
        }

        public ObservableCollection<AirSpeed> AirSpeeds { get; set; }

        public AirSettingsData SelectedAirMode
        {
            get => _selectedAirMode;
            set
            {
                if (SetProperty(ref _selectedAirMode, value))
                {
                    SelectedDevice.Mode = (AirMode)Enum.Parse(typeof(AirMode), value.Name);
                }
            }
        }

        public ObservableCollection<AirSettingsData> AirModes { get; } = new ObservableCollection<AirSettingsData>();

        private async Task OnAddScheduleCommand()
        {
            var popupViewModel = new SmartHomeAirSchedulePopupViewModel(null, AirModes, AirSpeeds);
            var popup = new SmartHomeAirSchedulePopup(popupViewModel);
            await IPopupService.Current.PushAsync(popup);

            Schedule newSchedule = await popupViewModel.Result.Task;
            if (newSchedule != null)
            {
                SelectedDevice.Schedules.Add(newSchedule);
            }

            await IPopupService.Current.PopAsync();
        }

        private async Task OnEditScheduleCommand(AirSchedule schedule)
        {
            var popupViewModel = new SmartHomeAirSchedulePopupViewModel(schedule, AirModes, AirSpeeds);
            var popup = new SmartHomeAirSchedulePopup(popupViewModel);
            await IPopupService.Current.PushAsync(popup);

            Schedule modifiedSchedule = await popupViewModel.Result.Task;
            if (modifiedSchedule != null)
            {
                var index = SelectedDevice.Schedules.IndexOf(schedule);
                SelectedDevice.Schedules.RemoveAt(index);
                SelectedDevice.Schedules.Insert(index, modifiedSchedule);
            }

            await IPopupService.Current.PopAsync();
        }

        private void OnDeleteScheduleCommand(Schedule item)
        {
            SelectedDevice.Schedules?.Remove(item);
        }

        private void LoadData()
        {
            AirModes.Clear();
            AirModes.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "SmartHome.json");
        }

        private AirDevice LoadAir(RoomDeviceItemData data)
        {
            AirDevice result;

            if (data != null)
            {
                result = new AirDevice
                {
                    Icon = data.Icon,
                    Name = data.Name,
                    Info = data.Info,
                    ScheduledActivity = data.ScheduledActivity,
                    IsOn = data.IsOn,
                    BackgroundColor = data.BackgroundColor,
                    Where = data.Where,
                    DeviceColor = data.DeviceColor
                };
            }
            else
            {
                // Default sample data
                result = new AirDevice
                {
                    IsOn = true
                };
            }

            result.OutdoorTemp = 53.6;
            result.RoomTemp = 71.6;
            result.Mode = AirMode.Heat;
            result.Speed = AirSpeed.High;
            result.Schedules = new ObservableCollection<Schedule>();

            return result;
        }
    }
}