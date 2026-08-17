/* [grial-metadata] id: Grial#ProductsGridVariantPage.xaml version: 1.0.1 */
using System;
using System.Threading.Tasks;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class ProductsGridVariantPage : ContentPage
    {
        public ProductsGridVariantPage()
        {
            InitializeComponent();

            BindingContext = new ProductsCatalogViewModel(variantPageName: $"{GetType().Name}.xaml");
        }
    }
}