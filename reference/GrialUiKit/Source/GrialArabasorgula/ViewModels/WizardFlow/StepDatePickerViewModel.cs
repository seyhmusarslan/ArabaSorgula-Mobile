/* [grial-metadata] id: Grial#StepDatePickerViewModel.cs version: 1.0.3 */
using System;
using UXDivers.Grial;
namespace arabasorgula
{
    public class StepDatePickerViewModel : StepViewModel<DateTime>
    {
        public StepDatePickerViewModel(string title, DateTime initValue, Func<DateTime, string> validation, Action next)
            : base(title, null, validation, next)
        {
            Value = initValue;
        }
    }
}

