/* [grial-metadata] id: Grial#ProductItemFullScreenPage.xaml version: 1.0.3 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class ProductItemFullScreenPage : ContentPage
    {
        public ProductItemFullScreenPage()
            : this(null)
        {
        }

        public ProductItemFullScreenPage(ProductData product)
        {
            InitializeComponent();

            BindingContext = new ProductItemViewViewModel(product?.Id, variantPageName: $"{GetType().Name}.xaml");
        }
    }
}