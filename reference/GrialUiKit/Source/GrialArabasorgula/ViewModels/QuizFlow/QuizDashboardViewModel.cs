/* [grial-metadata] id: Grial#QuizDashboardViewModel.cs version: 1.1.6 */
using System.Collections.ObjectModel;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
	public class QuizDashboardViewModel: ObservableObject
	{
        private readonly INavigation _navigation;
        private Action<QuizCategoryData> _scrollToAction;
        private double _gameProgress;
        private double _gameMaxProgress;
        private string _gameName;
        private int _gameLevel;

        public QuizDashboardViewModel(INavigation navigation, Action<QuizCategoryData> scrollToAction)
        {
            _navigation = navigation;
            _scrollToAction = scrollToAction;

            LoadData();

            OnBannerTappedCommand = new Command(OnGoToAchievements);
            OnCategoryTappedCommand = new Command<QuizCategoryData>(OnCategoryTapped);
            OnQuizTappedCommand = new Command<QuizContentData>(OnQuizTapped);
            PlayRandomCommand = new Command(OnPlayRandom);
            ReviewMistakesCommand = new Command(OnReviewMistakes);
            GoToAchievementsCommand = new Command(OnGoToAchievements);
        }

        public double GameProgress
        {
            get { return _gameProgress; }
            set { SetProperty(ref _gameProgress, value); }
        }

        public double GameMaxProgress
        {
            get { return _gameMaxProgress; }
            set { SetProperty(ref _gameMaxProgress, value); }
        }

        public string GameName
        {
            get { return _gameName; }
            set { SetProperty(ref _gameName, value); }
        }

        public int GameLevel
        {
            get { return _gameLevel; }
            set { SetProperty(ref _gameLevel, value); }
        }

        public ObservableCollection<QuizCategoryData> CategoriesList { get; } = new ObservableCollection<QuizCategoryData>();

        public ICommand OnBannerTappedCommand { get; }
        public ICommand OnCategoryTappedCommand { get; }
        public ICommand OnQuizTappedCommand { get; }
        public ICommand PlayRandomCommand { get; }
        public ICommand ReviewMistakesCommand { get; }
        public ICommand GoToAchievementsCommand { get; }

        private void OnGoToAchievements()
        {
            var vm = new QuizProfileAchievementsViewModel(GameName, GameProgress, GameMaxProgress);
            var page = new QuizProfileAchievementsPage(vm);

            _navigation.PushAsync(page);
        }

        private void OnCategoryTapped(QuizCategoryData item)
        {
            _scrollToAction.Invoke(item);
        }

        private async void OnQuizTapped(QuizContentData item)
        {
            if (item.Title != "90s Hip-Hop" && Application.Current != null && Application.Current.Windows.Count > 0)
            {
                await Application.Current.Windows[0].Page.DisplayAlertAsync("Demo App", "This is a demo app, it will always open the Hip-Hop game", "Ok");
            }

            var dialog = new QuizGamePage();
            await _navigation.PushModalAsync(new NavigationPage(dialog));
        }

        private async void OnPlayRandom()
        {
            if (Application.Current?.Windows.Count > 0 == false)
            {
                return;
            }

            await Application.Current.Windows[0].Page.DisplayAlertAsync("Demo App", "Play a random game", "Ok");
        }

        private async void OnReviewMistakes()
        {
            if (Application.Current?.Windows.Count > 0 == false)
            {
                return;
            }

            await Application.Current.Windows[0].Page.DisplayAlertAsync("Demo App", "Review mistakes in previous games", "Ok");
        }

        private void LoadData()
        {
            CategoriesList?.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Quiz.json");
        }
    }
}

