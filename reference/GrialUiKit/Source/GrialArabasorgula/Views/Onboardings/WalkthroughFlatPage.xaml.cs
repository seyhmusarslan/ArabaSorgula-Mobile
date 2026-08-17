/* [grial-metadata] id: Grial#WalkthroughFlatPage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class WalkthroughFlatPage : ContentPage
    {
        public WalkthroughFlatPage()
        {
            InitializeComponent();

            BindingContext = new WalkthroughViewModel($"{nameof(WalkthroughFlatPage)}.xaml", Navigation);
        }
    }
}