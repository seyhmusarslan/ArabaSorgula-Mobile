/* [grial-metadata] id: Grial#WalkthroughMinimalPage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class WalkthroughMinimalPage : ContentPage
    {
        public WalkthroughMinimalPage()
        {
            InitializeComponent();

            BindingContext = new WalkthroughViewModel($"{nameof(WalkthroughMinimalPage)}.xaml", Navigation);
        }
    }
}