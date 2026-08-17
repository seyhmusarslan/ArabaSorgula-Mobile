/* [grial-metadata] id: Grial#WizardMainViewModel.cs version: 1.1.6 */
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class WizardMainViewModel : ObservableObject
    {
        private int _position;
        private StepViewModel[] _steps;

        public WizardMainViewModel()
        {
            InitializeSteps();

            MoveEndedCommand = new Command<CarouselMovedEndedEventArgs>(OnMoveEnded);
        }

        public ICommand MoveNextCommand { get; set; }

        public ICommand MoveEndedCommand { get; }

        public StepViewModel[] Steps
        {
            get => _steps;
            set => SetProperty(ref _steps, value);
        }

        public StepViewModel CurrentStep => Position >= 0 && Position < Steps.Length ? Steps[Position] : null;

        public int Position
        {
            get => _position;
            set
            {
                SetProperty(ref _position, value);
                NotifyPropertyChanged(nameof(CurrentStep));
            }
        }

        private void OnMoveEnded(CarouselMovedEndedEventArgs param)
        {
            if (param.MovementDirection == CarouselMovedEndedEventArgs.Direction.Stayed)
            {
                // Force validation if the carousel stayed at the same position
                // to indicate why it can't advance, if that's the case
                CurrentStep.Validate();
            }
        }

        private void InitializeSteps()
        {
            Action next = () => MoveNextCommand?.Execute(null);

            var name = new StepEntryViewModel(
                title: "What's your name?", //StringNameTitle
                hint: "Enter your name", //StringNameHint
                validation: x => string.IsNullOrEmpty(x) ? "Please enter your name." : null, //StringNameValidate
                next);

            var birthday = new StepDatePickerViewModel(
                title: "When's your birthday?",//StringBirthdayTitle
                initValue: new DateTime(2000, 1, 1),
                validation: x => DateTime.Now.Subtract(x).TotalDays < 365 * 12 ? "You have to be older than 12 to proceed." : null, //StringBirthdayValidate
                next);

            var country = new StepCountryPickerViewModel(
                title: "Where do you live?", //StringCountryTitle
                hint: "Please select a country", //StringCountryHint
                validation: x => x != null ? null : "Please pick a country.",//StringCountryHint
                next);

            var phone = new StepPhoneViewModel(
                title: "What's your phone number?", //StringPhoneTitle
                hint: "Enter your number",//StringPhoneHint
                validation: x => string.IsNullOrEmpty(x) ? "Please enter your number." : null,//StringPhoneValidate
                country,
                next);

            var occupation = new StepRadioViewModel(
                title: "What better describe your current job?",//StringOccupationTitle
                validate: x => x != null ? null : "Please select an option.",//StringOccupationHint
                options: ["Developer", "Designer", "Product Manager", "Executive", "Other"],
                next);

            var checkbox = new StepCheckboxViewModel(
                title: "Terms and conditions",//StringTermsConditions
                hint: "I accept the terms and conditions.",//StringCheckboxHint
                validate: x => x == true ? null : "Please accept to continue.",//StringCheckboxValidate
                next);

            var final = new StepSuccessViewModel(
                mainText: "Welcome!",//StringFinalText
                secondaryText: "To a new world of possibilities, welcome to Grial UI Kit.", "Show me!",//(secondaryText)= WalkthroughTextWelcome /// (ButtonCaption)= ButtonShowMe
                next: () => {
                    if (Application.Current?.Windows.Count > 0 == false)
                    {
                        return;
                    }
                    
                    Application.Current?.Windows[0].Page.DisplayAlertAsync("Demo!", $"Thanks {name.Value} for using Grial :)", "OK");
                });

            Steps =
            [
                name, birthday, country, phone, occupation, checkbox, final
            ];
        }
    }
}
