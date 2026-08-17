/* [grial-metadata] id: Grial#StepCountryPickerViewModel.cs version: 1.1.6 */

using System.Windows.Input;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
    public class StepCountryPickerViewModel : StepViewModel<WizardCountryData>
    {
        public StepCountryPickerViewModel(string title, string hint, Func<WizardCountryData, string> validation, Action next)
            : base(title, hint, validation, next)
        {
            ShowCountriesCommand = new Command(() => IPopupService.Current.PushAsync(
                new WizardCountryListDialog(x =>
                {
                    Value = x;
                    if (IPopupService.Current.NavigationStack.Count > 0)
                    {
                        IPopupService.Current.PopAsync();
                    }
                })));
        }

        public ICommand ShowCountriesCommand { get; }
    }
}

