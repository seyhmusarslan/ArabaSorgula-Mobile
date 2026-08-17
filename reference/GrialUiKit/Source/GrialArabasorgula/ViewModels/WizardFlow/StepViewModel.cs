/* [grial-metadata] id: Grial#StepViewModel.cs version: 1.0.3 */
using System;
using arabasorgula.Resx;
using UXDivers.Grial;

namespace arabasorgula
{
    public abstract class StepViewModel : ObservableObject
    {
        private string _errorMessage, _nextCaption;
        private bool _isValid;

        public StepViewModel(string title, Action next)
        {
            Title = title;

            if (next != null)
            {
                NextCaption = AppResources.StringNext;
                NextCommand = new Command(next, () => IsValid);
                IsValid = true;
            }
        }

        public string NextCaption
        {
            get => _nextCaption;
            set => SetProperty(ref _nextCaption, value);
        }

        public string Title { get; }

        public bool IsValid
        {
            get => _isValid;
            set
            {
                SetProperty(ref _isValid, value);
                NextCommand?.ChangeCanExecute();
            }
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                SetProperty(ref _errorMessage, value);
                NextCommand?.ChangeCanExecute();
            }
        }

        public Command NextCommand { get; }

        public virtual void Validate()
        {
        }
    }
}

