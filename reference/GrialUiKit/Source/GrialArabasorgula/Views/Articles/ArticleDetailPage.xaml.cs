/* [grial-metadata] id: Grial#ArticleDetailPage.xaml version: 1.0.6 */
using System;
using arabasorgula.Resx;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class ArticleDetailPage : ContentPage
    {
        public ArticleDetailPage() 
            : this(null)
        {
        }

        public ArticleDetailPage(ArticleData article)
        {
            InitializeComponent();

            BindingContext = new ArticleDetailViewModel(article?.Id);
        }

        public void OnItemTapped(object sender, EventArgs e)
        {
            var articleCommentData = (sender as View).BindingContext as ArticleCommentData;
            DisplayAlertAsync(AppResources.StringMessageTapped, string.Format(AppResources.StringTappedOnAuthorMessage, articleCommentData?.From?.Name), AppResources.StringOK);
        }

        public void OnPrimaryActionButtonClicked(object sender, EventArgs e)
        {
            DisplayAlertAsync(AppResources.StringButtonTapped, AppResources.ButtonAddComment, AppResources.StringOK);
        }
    }
}