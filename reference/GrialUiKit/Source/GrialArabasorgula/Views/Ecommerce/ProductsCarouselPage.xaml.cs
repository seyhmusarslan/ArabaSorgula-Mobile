/* [grial-metadata] id: Grial#ProductsCarouselPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class ProductsCarouselPage : ContentPage
    {
        public ProductsCarouselPage()
        {
            InitializeComponent();

            var model = new ProductsCatalogViewModel();
            var list = new List<ProductItemViewViewModel>();

            for (var i = 0; i < model.List.Count; i++)
            {
                list.Add(new ProductItemViewViewModel(model.List[i]?.Id));
            }

            BindingContext = list;
        }
    }
}