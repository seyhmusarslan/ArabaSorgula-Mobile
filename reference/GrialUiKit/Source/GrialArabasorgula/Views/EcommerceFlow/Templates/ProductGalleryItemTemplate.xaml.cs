/* [grial-metadata] id: Grial#ProductGalleryItemTemplate.xaml version: 1.0.1 */
using System;
using UXDivers.Grial;

namespace arabasorgula 
{
    public partial class ProductGalleryItemTemplate : ContentView
    {
        public ProductGalleryItemTemplate()
        {
            InitializeComponent();
        }

        private async void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            var productView = new ProductDetailPage(
                ((VisualElement)sender).BindingContext as FlowProductData);

            await Navigation.PushAsync(productView);
        }
    }
}
