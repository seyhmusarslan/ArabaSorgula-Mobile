/* [grial-metadata] id: Grial#StepSuccessViewModel.cs version: 1.0.3 */
using System;
using UXDivers.Grial;
namespace arabasorgula
{
    public class StepSuccessViewModel : StepViewModel
    {
        public StepSuccessViewModel(string mainText, string secondaryText, string buttonCaption, Action next)
            : base(null, next)
        {
            MainText = mainText;
            SecondaryText = secondaryText;
            NextCaption = buttonCaption;
        }

        public string MainText { get; }
        public string SecondaryText { get; }
    }
}

