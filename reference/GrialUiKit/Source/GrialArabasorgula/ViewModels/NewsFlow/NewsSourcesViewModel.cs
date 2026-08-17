/* [grial-metadata] id: Grial#NewsSourcesViewModel.cs version: 1.1.6 */
using System;
using System.Collections.ObjectModel;
using UXDivers.Grial;

namespace arabasorgula
{
	public class NewsSourcesViewModel : ObservableObject
	{
        private readonly INavigation _navigation;

        public NewsSourcesViewModel(INavigation navigation)
        {
            _navigation = navigation;
            LoadData();

            ToggleFollowCommand = new Command<NewsSourcesData>((s) => s.IsFollowing = !s.IsFollowing);
            SourceTappedCommand = new Command<NewsSourcesData>(GoToSource);
        }

        public Command ToggleFollowCommand { get; }
        public Command SourceTappedCommand { get; }

        public ObservableCollection<NewsSourcesData> Sources { get; } = new ObservableCollection<NewsSourcesData>();

        private void GoToSource(NewsSourcesData source)
        {
            if (source.Name == "The New Worker")
            {
                _navigation.PushAsync(new NewsSourceProfilePage());
            }
            else if (Application.Current != null && Application.Current.Windows.Count > 0)
            {
                Application.Current.Windows[0].Page.DisplayAlertAsync("Source Tapped", "Pick source 'The New Worker' to see details", "Ok");
            }
        }

        private void LoadData()
        {
            Sources.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "News.json");
        }
    }
}