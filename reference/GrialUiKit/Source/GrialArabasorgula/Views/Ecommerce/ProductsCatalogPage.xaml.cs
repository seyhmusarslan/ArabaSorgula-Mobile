/* [grial-metadata] id: Grial#ProductsCatalogPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class ProductsCatalogPage : ContentPage
    {
        public ProductsCatalogPage()
        {
            InitializeComponent();

            BindingContext = new ProductsCatalogViewModel();
        }

        public async void OnItemSelected(object sender, EventArgs e)
        {
            var selectedItem = ((View)sender).BindingContext;
            if (selectedItem != null)
            {
                var productPage = new ProductItemViewPage(selectedItem as ProductData);

                await Navigation.PushAsync(productPage);
                //((View)sender).SelectedItem = null;
            }
        }
    }
}