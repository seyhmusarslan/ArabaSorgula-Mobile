/* [grial-metadata] id: Grial#SmartHomeLightSettingsViewModel.cs version: 3.0.6 */

using System.Collections.ObjectModel;
using System.Windows.Input;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
    public class SmartHomeLightSettingsViewModel : ObservableObject
    {
        private LightDevice _selectedDevice;

        public SmartHomeLightSettingsViewModel(RoomDeviceItemData data = null)
        {
            AddScheduleCommand = new Command(async () => await OnAddScheduleCommand());
            EditScheduleCommand = new Command<LightSchedule>(async (item) => await OnEditScheduleCommand(item));
            DeleteScheduleCommand = new Command<Schedule>(OnDeleteScheduleCommand);

            LoadData();

            SelectedDevice = LoadLight(data);
        }

        public LightDevice SelectedDevice
        {
            get { return _selectedDevice; }
            set { SetProperty(ref _selectedDevice, value); }
        }

        public ObservableCollection<string> ColorScenes { get; } = new ObservableCollection<string>();

        public ICommand AddScheduleCommand { get; }
        public ICommand EditScheduleCommand { get; }
        public ICommand DeleteScheduleCommand { get; }

        private async Task OnAddScheduleCommand()
        {
            var defaultSchedule = new LightSchedule
            {
                Intensity = 0.5,
                From = "13:00",
                To = "15:00",
                When = "Daily"
            };

            var popupViewModel = new SmartHomeLightSchedulePopupViewModel(defaultSchedule, ColorScenes);
            var popup = new SmartHomeLightSchedulePopup(popupViewModel);
            await IPopupService.Current.PushAsync(popup);

            Schedule newSchedule = await popupViewModel.Result.Task;
            if (newSchedule != null)
            {
                SelectedDevice.Schedules.Add(newSchedule);
            }

            await IPopupService.Current.PopAsync();
        }

        private async Task OnEditScheduleCommand(LightSchedule schedule)
        {
            var popupViewModel = new SmartHomeLightSchedulePopupViewModel(schedule, ColorScenes);
            var popup = new SmartHomeLightSchedulePopup(popupViewModel);
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
            SelectedDevice.Schedules.Remove(item);
        }

        private void LoadData()
        {
            ColorScenes.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "SmartHome.json");
        }

        private LightDevice LoadLight(RoomDeviceItemData data)
        {
            LightDevice result;

            if (data != null)
            {
                result = new LightDevice
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
                result = new LightDevice
                {
                    IsOn = true
                };
            }

            result.Intensity = 0.4;
            result.ColorScene = ColorScenes?.FirstOrDefault();
            result.Schedules = new ObservableCollection<Schedule>();

            return result;
        }
    }
}
