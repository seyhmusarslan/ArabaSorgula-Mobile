/* [grial-metadata] id: Grial#ArticlesBrowserViewModel.cs version: 1.0.1 */
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class ArticlesBrowserViewModel : ObservableObject
    {
        public ArticlesBrowserViewModel()
            : base(listenCultureChanges: true)
        {
            LoadData();
        }

        public ObservableCollection<ArticleData> Articles { get; } = new ObservableCollection<ArticleData>();
        public ObservableCollection<ArticleData> Related { get; } = new ObservableCollection<ArticleData>();
        public ObservableCollection<ArticleData> Featured { get; } = new ObservableCollection<ArticleData>();

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            Articles.Clear();
            Related.Clear();
            Featured.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Articles.json");
        }
    }
}
