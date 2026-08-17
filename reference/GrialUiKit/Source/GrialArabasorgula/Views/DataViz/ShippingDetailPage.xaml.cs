/* [grial-metadata] id: Grial#ShippingDetailPage.xaml version: 1.0.6 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class ShippingDetailPage : ContentPage
    {
        public ShippingDetailPage()
        {
            InitializeComponent();

            BindingContext = new ShippingDetailViewModel();
        }
    }
}
