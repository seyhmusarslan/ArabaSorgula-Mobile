/* [grial-metadata] id: Grial#WalkthroughVariantPage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class WalkthroughVariantPage : ContentPage
    {
        public WalkthroughVariantPage()
        {
            InitializeComponent();

            BindingContext = new WalkthroughViewModel($"{nameof(WalkthroughVariantPage)}.xaml", Navigation);
        }
    }
}