/* [grial-metadata] id: Grial#NewsListViewModel.cs version: 1.0.1 */
using System;
using System.Collections.ObjectModel;
using UXDivers.Grial;

namespace arabasorgula
{
    public class NewsListViewModel : ObservableObject
    {
        private readonly INavigation _navigation;

        public NewsListViewModel(INavigation navigation)
        {
            _navigation = navigation;
            LoadData();

            ToggleFavoriteCommand = new Command<NewsArticleData>((a) => a.IsFavorite = !a.IsFavorite);
            GoToArticleCommand = new Command<NewsArticleData>(GoToArticle);
        }

        public Command ToggleFavoriteCommand { get; }
        public Command GoToArticleCommand { get; }

        public ObservableCollection<NewsArticleData> List { get; } = new ObservableCollection<NewsArticleData>();
        public ObservableCollection<NewsArticleData> Featured { get; } = new ObservableCollection<NewsArticleData>();

        private void GoToArticle(NewsArticleData article)
        {
            _navigation.PushAsync(new NewsDetailPage(article));
        }

        private void LoadData()
        {
            List.Clear();
            Featured.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "News.json");
        }
    }
}