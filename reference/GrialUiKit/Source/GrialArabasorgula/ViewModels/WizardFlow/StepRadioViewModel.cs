/* [grial-metadata] id: Grial#StepRadioViewModel.cs version: 1.0.3 */
using System;
using UXDivers.Grial;
namespace arabasorgula
{
    public class StepRadioViewModel : StepViewModel<string>
    {
        public StepRadioViewModel(string title, Func<string, string> validate, string[] options, Action next)
            : base(title, null, validate, next)
        {
            Options = options;
        }

        public string[] Options { get; }
    }
}

