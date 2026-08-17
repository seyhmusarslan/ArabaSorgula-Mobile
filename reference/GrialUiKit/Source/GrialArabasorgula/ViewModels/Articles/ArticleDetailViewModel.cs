/* [grial-metadata] id: Grial#ArticleDetailViewModel.cs version: 1.0.1 */
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using UXDivers.Grial;

namespace arabasorgula
{
    public class ArticleDetailViewModel : ObservableObject
    {
        private readonly string _articleId;
        private ArticleData _article;

        public ArticleDetailViewModel(string articleId = null)
            : base(listenCultureChanges: true)
        {
            _articleId = articleId;

            LoadData();
        }

        public ArticleData Article
        {
            get { return _article; }
            set { SetProperty(ref _article, value); }
        }

        public ObservableCollection<ArticleCommentData> Comments { get; } = new ObservableCollection<ArticleCommentData>();

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            Comments.Clear();
            Article = null;

            JsonHelper.Instance.LoadViewModel(this, source: "Articles.json");

            if (_articleId != null)
            {
                Article = new ArticlesListViewModel()
                    .List.FirstOrDefault(article => article.Id == _articleId);
            }
        }
    }
}
