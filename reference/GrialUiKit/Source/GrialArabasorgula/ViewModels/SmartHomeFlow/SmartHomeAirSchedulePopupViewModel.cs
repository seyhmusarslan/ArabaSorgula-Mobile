/* [grial-metadata] id: Grial#SmartHomeAirSchedulePopupViewModel.cs version: 1.1.6 */

using System.Collections.ObjectModel;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
    public class SmartHomeAirSchedulePopupViewModel : SmartHomeSchedulePopupViewModel
    {
        private AirSchedule _itemToEdit;
        private AirSpeed? _speed;
        private AirSettingsData _mode;
        private double _temperature = -1;

        public SmartHomeAirSchedulePopupViewModel(AirSchedule item, ObservableCollection<AirSettingsData> airModes,
            ObservableCollection<AirSpeed> airSpeeds) : base(item)
        {
            SaveCommand = new Command(
                OnSaveCommand,
                canExecute: () => Temperature >= 0 && Mode != null && Speed != null && (When != null || Days?.Count > 0));

            Result = new TaskCompletionSource<Schedule>();

            _itemToEdit = item;

            Temperature = 75;

            if (item != null)
            {
                Temperature = item.Temperature;
                Mode = airModes.FirstOrDefault(m => m.Name == item.Mode.ToString());
                Speed = item.Speed;
            }

            AirModes = airModes;
            AirSpeeds = airSpeeds;
        }

        public TaskCompletionSource<Schedule> Result { get; }

        public double Temperature
        {
            get => _temperature;
            set
            {
                if (SetProperty(ref _temperature, value))
                {
                    if (SaveCommand is Command cmd)
                    {
                        cmd?.ChangeCanExecute();
                    }
                }
            }
        }

        public ObservableCollection<AirSpeed> AirSpeeds { get; }
        public ObservableCollection<AirSettingsData> AirModes { get; }

        public AirSettingsData Mode
        {
            get => _mode;
            set
            {
                if (SetProperty(ref _mode, value))
                {
                    if (SaveCommand is Command cmd)
                    {
                        cmd?.ChangeCanExecute();
                    }
                }
            }
        }

        public AirSpeed? Speed
        {
            get => _speed;
            set
            {
                if (SetProperty(ref _speed, value))
                {
                    if (SaveCommand is Command cmd)
                    {
                        cmd?.ChangeCanExecute();
                    }
                }
            }
        }

        private void OnSaveCommand()
        {
            if (_itemToEdit == null)
            {
                _itemToEdit = new AirSchedule
                {
                    From = From.ToString(@"hh\:mm"),
                    To = To.ToString(@"hh\:mm"),
                    When = When,
                    Days = Days.ToList(),
                    Temperature = Temperature,
                    Mode = (AirMode)Enum.Parse(typeof(AirMode), Mode.Name),
                    Speed = Speed ?? default(AirSpeed)
                };
            }
            else
            {
                _itemToEdit.From = From.ToString(@"hh\:mm");
                _itemToEdit.To = To.ToString(@"hh\:mm");
                _itemToEdit.When = When;
                _itemToEdit.Days = Days.ToList();
                _itemToEdit.Temperature = Temperature;
                _itemToEdit.Mode = (AirMode)Enum.Parse(typeof(AirMode), Mode.Name);
                _itemToEdit.Speed = Speed ?? default(AirSpeed);
            }

            Result.TrySetResult(_itemToEdit);

            IPopupService.Current.PopAsync();
        }
    }
}