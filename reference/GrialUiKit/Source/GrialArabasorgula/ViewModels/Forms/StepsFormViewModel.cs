/* [grial-metadata] id: Grial#StepsFormViewModel.cs version: 1.0.5 */
using System.Collections.ObjectModel;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class StepsFormViewModel : ObservableObject
    {
        private readonly INavigation _navigation;
        private FormStep _currentStep;

        public StepsFormViewModel(INavigation navigation)
            : base(listenCultureChanges: true)
        {
            _navigation = navigation;

            LoadData();

            NextCommand = new Command(OnNext);
        }

        public ObservableCollection<PickerData> AppUsageData { get; } = [];
        public ObservableCollection<PickerData> FeedbackData { get; } = [];
        public ObservableCollection<FormStep> Steps { get; } = [];

        public ICommand NextCommand { get; }

        public FormStep CurrentStep
        {
            get => _currentStep;
            set => SetProperty(ref _currentStep, value);
        }

        private void LoadData()
        {
            AppUsageData.Clear();
            FeedbackData.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Forms.json");

            InitializeSteps();

            CurrentStep = Steps.FirstOrDefault();
        }

        private void InitializeSteps()
        {
            Steps.Add(new FormStep
            {
                Icon = "\uea22",
                Title = "Profile",//PageTitleProfile
                PrimaryActionText = "Continue",//StringContinue
                Form = new FormStepOneViewModel()
            });
            Steps.Add(new FormStep
            {
                Icon = "\ue9ce",
                Title = "Usage",//StringUsage
                PrimaryActionText = "Continue",////StringContinue
                Form = new FormStepTwoViewModel()
                {
                    Pickers = [.. AppUsageData]
                }
            });
            Steps.Add(new FormStep
            {
                Icon = "\ue9fd",
                Title = "Feedback",//StringFeedback
                PrimaryActionText = "Send",//StringSend
                Form = new FormStepThreeViewModel()
                {
                    Pickers = [.. FeedbackData]
                }
            });
        }

        private async void OnNext(object obj)
        {
            var index = Steps.IndexOf(CurrentStep) + 1;
            if (index >= Steps.Count)
            {
                await _navigation.PopAsync();
                return;
            }

            CurrentStep = Steps.ElementAtOrDefault(index);
        }
    }
}


