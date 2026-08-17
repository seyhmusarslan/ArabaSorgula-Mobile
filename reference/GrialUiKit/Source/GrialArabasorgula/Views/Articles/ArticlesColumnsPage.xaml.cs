/* [grial-metadata] id: Grial#ArticlesColumnsPage.xaml version: 1.0.1 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class ArticlesColumnsPage : ContentPage
    {
        public ArticlesColumnsPage()
        {
            InitializeComponent();

            BindingContext = new ArticlesColumnsViewModel();
        }

        private async void OnItemTapped(object sender, EventArgs e)
        {
            var item = ((BindableObject)sender).BindingContext;
            var articlePage = new ArticleDetailPage(item as ArticleData);

            await Navigation.PushAsync(articlePage);
        }
    }
}
