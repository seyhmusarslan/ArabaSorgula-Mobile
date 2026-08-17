/* [grial-metadata] id: Grial#StepEntryViewModel.cs version: 1.0.3 */
using System;
using UXDivers.Grial;
namespace arabasorgula
{
    public class StepEntryViewModel : StepViewModel<string>
    {
        public StepEntryViewModel(string title, string hint, Func<string, string> validation, Action next)
            : base(title, hint, validation, next)
        {
        }
    }
}

