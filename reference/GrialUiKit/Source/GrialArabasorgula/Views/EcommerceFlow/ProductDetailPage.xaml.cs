/* [grial-metadata] id: Grial#ProductDetailPage.xaml version: 1.0.3 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class ProductDetailPage : ContentPage
    {
        public ProductDetailPage()
        {
            InitializeComponent();

            // Use any product to showcase the page
            BindingContext = new EcommerceMainViewModel().HighlightedProducts[0];
        }

        public ProductDetailPage(FlowProductData product)
        { 
            InitializeComponent();

            BindingContext = product;
        }

        private async void OnBuy(object sender, EventArgs e)
        {
            var page = new OrderConfirmationPage(
                ((VisualElement)sender).BindingContext as FlowProductData);

            await Navigation.PushAsync(page);
        }
    }
}
