/* [grial-metadata] id: Grial#EcommerceMainPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class EcommerceMainPage : ContentPage
    {
        public EcommerceMainPage()
        {
            InitializeComponent();

            BindingContext = new EcommerceMainViewModel();
        }
    }
}
