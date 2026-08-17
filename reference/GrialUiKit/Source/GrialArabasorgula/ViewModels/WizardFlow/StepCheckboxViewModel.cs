/* [grial-metadata] id: Grial#StepCheckboxViewModel.cs version: 1.0.3 */
using System;
using UXDivers.Grial;
namespace arabasorgula
{
    public class StepCheckboxViewModel : StepViewModel<bool?>
    {
        public StepCheckboxViewModel(string title, string hint, Func<bool?, string> validate, Action next)
            : base(title, hint, validate, next)
        {
        }
    }
}

