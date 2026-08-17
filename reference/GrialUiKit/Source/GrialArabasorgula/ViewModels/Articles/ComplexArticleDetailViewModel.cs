/* [grial-metadata] id: Grial#ComplexArticleDetailViewModel.cs version: 1.0.1 */
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class ComplexArticleDetailViewModel : ObservableObject
    {
        private readonly string _variantPageName;
        private ArticleData _article;

        public ComplexArticleDetailViewModel(string variantPageName)
            : base(listenCultureChanges: true)
        {
            _variantPageName = variantPageName;

            LoadData();
        }

        public ArticleData Article
        {
            get { return _article; }
            set { SetProperty(ref _article, value); }
        }

        public ObservableCollection<ArticleData> Gallery { get; } = new ObservableCollection<ArticleData>();
        public ObservableCollection<ArticleData> Related { get; } = new ObservableCollection<ArticleData>();
        public ObservableCollection<ArticleCommentData> Comments { get; } = new ObservableCollection<ArticleCommentData>();
        public ObservableCollection<ArticleCardData> Cards { get; } = new ObservableCollection<ArticleCardData>();

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            Cards.Clear();
            Comments.Clear();
            Gallery.Clear();
            Related.Clear();
            Article = null;

            JsonHelper.Instance.LoadViewModel(this, pageName: _variantPageName, source: "Articles.json");
        }
    }
}