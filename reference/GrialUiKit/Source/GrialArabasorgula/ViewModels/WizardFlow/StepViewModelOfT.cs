/* [grial-metadata] id: Grial#StepViewModelOfT.cs version: 1.0.3 */
using System;
using UXDivers.Grial;
namespace arabasorgula
{
    public abstract class StepViewModel<T> : StepViewModel
    {
        private readonly Func<T, string> _validate;
        private T _value;

        public StepViewModel(string title, string hint, Func<T, string> validate, Action next)
            : base(title, next)
        {
            _validate = validate;
            Validate(false);
            HintText = hint;
        }

        public string HintText { get; }

        public T Value
        {
            get => _value;
            set
            {
                SetProperty(ref _value, value);
                Validate();
            }
        }

        public override void Validate()
        {
            Validate(displayMessage: true);
        }

        private void Validate(bool displayMessage = true)
        {
            var message = _validate?.Invoke(Value);
            IsValid = message == null;
            ErrorMessage = displayMessage ? message : null;
        }
    }
}

