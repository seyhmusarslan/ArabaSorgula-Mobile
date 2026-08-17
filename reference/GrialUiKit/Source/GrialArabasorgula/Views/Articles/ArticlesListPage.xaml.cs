/* [grial-metadata] id: Grial#ArticlesListPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class ArticlesListPage : ContentPage
    {
        public ArticlesListPage()
        {
            InitializeComponent();

            BindingContext = new ArticlesListViewModel();
        }

        private async void OnItemTapped(object sender, EventArgs e)
        {
            var selectedItem = ((View)sender).BindingContext;
            var articlePage = new ArticleDetailPage(selectedItem as ArticleData);

            await Navigation.PushAsync(articlePage);
        }
    }
}
