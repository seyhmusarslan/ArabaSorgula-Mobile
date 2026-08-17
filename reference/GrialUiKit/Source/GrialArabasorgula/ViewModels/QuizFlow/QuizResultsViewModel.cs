/* [grial-metadata] id: Grial#QuizResultsViewModel.cs version: 1.0.4 */
using System.Collections.ObjectModel;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
	public class QuizResultsViewModel: ObservableObject
	{
        private readonly INavigation _navigation;

        private double _completionValue;
        private string _quizTitle;

        public QuizResultsViewModel(INavigation navigation)
        {
            _navigation = navigation;

            LoadData();

            FinishCommand = new Command(OnFinish);

        }
        public ICommand FinishCommand { get; }

        public string QuizTitle
        {
            get { return _quizTitle; }
            set { SetProperty(ref _quizTitle, value); }
        }

        public double CompletionValue
        {
            get { return _completionValue; }
            set { SetProperty(ref _completionValue, value); }
        }

        public ObservableCollection<QuizCompletionStatsData> ResultsData { get; } = new ObservableCollection<QuizCompletionStatsData>();

        private async void OnFinish()
        {
            await _navigation.PopModalAsync();
        }

        private void LoadData()
        {
            ResultsData.Clear();          

            JsonHelper.Instance.LoadViewModel(this, source: "Quiz.json");
        }
    }
}

