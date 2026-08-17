/* [grial-metadata] id: Grial#ArticlesListVariantPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class ArticlesListVariantPage : ContentPage
    {
        public ArticlesListVariantPage()
        {
            InitializeComponent();

            BindingContext = new ArticlesListViewModel(variantPageName: $"{GetType().Name}.xaml");
        }

        private async void OnItemTapped(object sender, EventArgs e)
        {
            var selectedItem = ((View)sender).BindingContext;
            var articlePage = new ArticleDetailPage(selectedItem as ArticleData);

            await Navigation.PushAsync(articlePage);
        }
    }
}
