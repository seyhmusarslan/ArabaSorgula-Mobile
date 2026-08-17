/* [grial-metadata] id: Grial#NewsTopicsViewModel.cs version: 1.1.6 */
using System;
using System.Collections.ObjectModel;
using UXDivers.Grial;

namespace arabasorgula
{
    public class NewsTopicsViewModel : ObservableObject
    {
        public NewsTopicsViewModel()
        {
            LoadData();

            TopicTappedCommand = new Command<NewsTopicData>(GoToTopic);
        }

        public Command TopicTappedCommand { get; }
        
        public ObservableCollection<NewsTopicData> Topics { get; } = new ObservableCollection<NewsTopicData>();

        private void GoToTopic(NewsTopicData topic)
        {
            if (Application.Current == null || Application.Current.Windows.Count == 0)
            {
                return;
            }

            Application.Current?.Windows[0]?.Page.DisplayAlertAsync("Topic Tap", $"Topic '{topic.SectionTitle}' has been tapped.", "Ok");
        }

        private void LoadData()
        {
            Topics.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "News.json");
        }
    }
}