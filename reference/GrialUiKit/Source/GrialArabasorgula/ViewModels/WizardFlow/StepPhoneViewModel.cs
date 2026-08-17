/* [grial-metadata] id: Grial#StepPhoneViewModel.cs version: 1.0.3 */
using System;
using UXDivers.Grial;
namespace arabasorgula
{
    public class StepPhoneViewModel : StepViewModel<string>
    {
        public StepPhoneViewModel(string title, string hint, Func<string, string> validation, StepCountryPickerViewModel country, Action next)
            : base(title, hint, validation, next)
        {
            Country = country;
        }

        public StepCountryPickerViewModel Country { get; }
    }
}

