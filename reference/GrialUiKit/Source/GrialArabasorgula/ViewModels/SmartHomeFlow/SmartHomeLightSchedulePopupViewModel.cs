/* [grial-metadata] id: Grial#SmartHomeSchedulePopupViewModel.cs version: 2.0.6 */

using System.Collections.ObjectModel;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
	public class SmartHomeLightSchedulePopupViewModel : SmartHomeSchedulePopupViewModel
	{
        private LightSchedule _itemToEdit;
        private string _selectedScene;
        private double _intensity;
        private ObservableCollection<string> _colorScenes;

        public SmartHomeLightSchedulePopupViewModel(LightSchedule item, ObservableCollection<string> colorScenes) : base(item)
        {
            SaveCommand = new Command(
                OnSaveCommand,
                canExecute: () => SelectedScene != null && (When != null || Days?.Count > 0));

            Result = new TaskCompletionSource<Schedule>();

            _itemToEdit = item;

            SelectedScene = item.ColorScene ?? colorScenes.FirstOrDefault();
            Intensity = item.Intensity;
            ColorScenes = colorScenes;
        }

        public TaskCompletionSource<Schedule> Result { get; }

        public string SelectedScene
        {
            get => _selectedScene;
            set
            {
                SetProperty(ref _selectedScene, value);

                if (SaveCommand is Command cmd)
                {
                    cmd?.ChangeCanExecute();
                }
            }
        }

        public double Intensity
        {
            get => _intensity;
            set => SetProperty(ref _intensity, value);
        }

        public ObservableCollection<string> ColorScenes
        {
            get => _colorScenes;
            set => SetProperty(ref _colorScenes, value);
        }

        private void OnSaveCommand()
        {
            if (_itemToEdit == null)
            {
                _itemToEdit = new LightSchedule
                {
                    ColorScene = SelectedScene,
                    From = From.ToString(@"hh\:mm"),
                    To = To.ToString(@"hh\:mm"),
                    When = When,
                    Days = Days.ToList(),
                    Intensity = Intensity
                };
            }
            else
            {
                _itemToEdit.ColorScene = SelectedScene;
                _itemToEdit.From = From.ToString(@"hh\:mm");
                _itemToEdit.To = To.ToString(@"hh\:mm");
                _itemToEdit.When = When;
                _itemToEdit.Days = Days.ToList();
                _itemToEdit.Intensity = Intensity;
            }

            Result.TrySetResult(_itemToEdit);

            IPopupService.Current.PopAsync();
        }
    }
}

