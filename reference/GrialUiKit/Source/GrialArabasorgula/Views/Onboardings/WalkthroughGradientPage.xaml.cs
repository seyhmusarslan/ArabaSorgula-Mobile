/* [grial-metadata] id: Grial#WalkthroughGradientPage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class WalkthroughGradientPage : ContentPage
    {
        public WalkthroughGradientPage()
        {
            InitializeComponent();

            BindingContext = new WalkthroughViewModel($"{nameof(WalkthroughGradientPage)}.xaml", Navigation);
        }
    }
}
