/* [grial-metadata] id: Grial#WalkthroughPage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class WalkthroughPage : ContentPage
    {
        public WalkthroughPage()
        {
            InitializeComponent();

            BindingContext = new WalkthroughViewModel($"{nameof(WalkthroughPage)}.xaml", Navigation);
        }
    }
}