/* [grial-metadata] id: Grial#WalkthroughIllustrationPage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class WalkthroughIllustrationPage : ContentPage
    {
        public WalkthroughIllustrationPage()
        {
            InitializeComponent();

            BindingContext = new WalkthroughViewModel($"{nameof(WalkthroughIllustrationPage)}.xaml", Navigation);
        }
    }
}
