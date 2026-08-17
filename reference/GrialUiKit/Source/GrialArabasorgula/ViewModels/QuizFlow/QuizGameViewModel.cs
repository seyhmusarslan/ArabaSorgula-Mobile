/* [grial-metadata] id: Grial#QuizGameViewModel.cs version: 1.0.4 */
using System.Collections.ObjectModel;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
	public class QuizGameViewModel: ObservableObject
	{
        private readonly INavigation _navigation;

        private string _quizTitle;

        public QuizGameViewModel(INavigation navigation)
        {
            _navigation = navigation;

            LoadData();

            ReviewResultsCommand = new Command(OnReviewResults);
            CloseCommand = new Command(OnClose);
        }

        public ICommand ReviewResultsCommand { get; }
        public ICommand CloseCommand { get; }

        public string QuizTitle
        {
            get { return _quizTitle; }
            set { SetProperty(ref _quizTitle, value); }
        }

        public ObservableCollection<QuizFactData> HipHopFacts { get; } = new ObservableCollection<QuizFactData>();

        private async void OnReviewResults()
        {
            var resultsPage = new QuizResultsPage();
            resultsPage.BindingContext = new QuizResultsViewModel(resultsPage.Navigation);

            await _navigation.PushAsync(resultsPage);
        }

        private async void OnClose()
        {
            await _navigation.PopModalAsync();
        }

        private void LoadData()
        {
            HipHopFacts.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Quiz.json");
        }
    }
}