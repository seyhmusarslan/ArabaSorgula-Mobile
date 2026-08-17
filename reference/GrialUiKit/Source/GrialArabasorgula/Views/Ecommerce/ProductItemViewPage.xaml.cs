/* [grial-metadata] id: Grial#ProductItemViewPage.xaml version: 1.0.1 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class ProductItemViewPage : ContentPage
    {
        public ProductItemViewPage() : this(null)
        {
            InitializeComponent();
        }

        public ProductItemViewPage(ProductData product)
        {
            InitializeComponent();

            BindingContext = new ProductItemViewViewModel(product?.Id);
        }
    }
}