/* [grial-metadata] id: Grial#SocialCardPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class SocialCardPage : ContentPage
    {
        public SocialCardPage()
        {
            InitializeComponent();

            BindingContext = new SocialViewModel(variantPageName: "SocialCardPage.xaml");
        }
    }
}
