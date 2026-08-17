/* [grial-metadata] id: Grial#ProductGridItemTemplate.xaml version: 1.0.1 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class ProductGridItemTemplate : ContentView
    {
        public ProductGridItemTemplate()
        {
            InitializeComponent();
        }

        private async void OnProductTapped(object sender, EventArgs e)
        {
            var productPage = new ProductItemViewPage(BindingContext as ProductData);

            await Navigation.PushAsync(productPage);
        }
    }
}