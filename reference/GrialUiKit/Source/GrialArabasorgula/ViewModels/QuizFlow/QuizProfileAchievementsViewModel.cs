/* [grial-metadata] id: Grial#QuizProfileAchievementsViewModel.cs version: 1.0.4 */
using System.Collections.ObjectModel;
using UXDivers.Grial;

namespace arabasorgula
{
	public class QuizProfileAchievementsViewModel : ObservableObject
	{
        private QuizActivityChartData _chartSeries;
        private string _quizTitle;
        private double _quizLevel;
        private double _quizProgress;
        private double _quizMaxProgress;

        public QuizProfileAchievementsViewModel(string name, double progress, double maxProgress)
            : this()
        {
            QuizTitle = name;
            QuizProgress = progress;
            QuizMaxProgress = maxProgress;
        }

        public QuizProfileAchievementsViewModel()
        {
            QuizMaxProgress = 1;
            LoadData();
        }

        public string QuizTitle
        {
            get { return _quizTitle; }
            set { SetProperty(ref _quizTitle, value); }
        }

        public double QuizLevel
        {
            get { return _quizLevel; }
            set { SetProperty(ref _quizLevel, value); }
        }

        public double QuizProgress
        {
            get { return _quizProgress; }
            set { SetProperty(ref _quizProgress, value); }
        }

        public double QuizMaxProgress
        {
            get { return _quizMaxProgress; }
            set { SetProperty(ref _quizMaxProgress, value); }
        }

        public ObservableCollection<QuizUserProgressData> UserStats { get; } = new ObservableCollection<QuizUserProgressData>();

        public ObservableCollection<QuizDailyTaskData> DailyTasks { get; } = new ObservableCollection<QuizDailyTaskData>();

        public QuizActivityChartData ChartSeries
        {
            get { return _chartSeries; }
            set { SetProperty(ref _chartSeries, value); }
        }

        private void LoadData()
        {
            UserStats.Clear();
            DailyTasks.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Quiz.json");
        }
    }
}