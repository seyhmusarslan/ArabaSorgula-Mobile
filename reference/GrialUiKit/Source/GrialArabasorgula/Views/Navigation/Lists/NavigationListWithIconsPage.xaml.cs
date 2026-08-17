/* [grial-metadata] id: Grial#NavigationListWithIconsPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class NavigationListWithIconsPage : ContentPage
    {
        public NavigationListWithIconsPage()
        {
            InitializeComponent();

            BindingContext = new NavigationViewModel(variantPageName: $"{GetType().Name}.xaml");
        }
    }
}
