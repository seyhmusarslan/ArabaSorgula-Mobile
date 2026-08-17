/* [grial-metadata] id: Grial#WalkthroughImagePage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class WalkthroughImagePage : ContentPage
    {
        public WalkthroughImagePage()
        {
            InitializeComponent();

            BindingContext = new WalkthroughViewModel($"{nameof(WalkthroughImagePage)}.xaml", Navigation);
        }
    }
}
