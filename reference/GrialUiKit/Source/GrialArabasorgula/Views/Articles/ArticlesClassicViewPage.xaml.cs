/* [grial-metadata] id: Grial#ArticlesClassicViewPage.xaml version: 1.0.1 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class ArticlesClassicViewPage : ContentPage
    {
        public ArticlesClassicViewPage()
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
