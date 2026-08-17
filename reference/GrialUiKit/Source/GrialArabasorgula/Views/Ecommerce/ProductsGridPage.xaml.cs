/* [grial-metadata] id: Grial#ProductsGridPage.xaml version: 1.0.1 */
using System;
using System.Threading.Tasks;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class ProductsGridPage : ContentPage
    {
        public ProductsGridPage()
        {
            InitializeComponent();

            BindingContext = new ProductsCatalogViewModel(variantPageName: $"{GetType().Name}.xaml");
        }
    }
}