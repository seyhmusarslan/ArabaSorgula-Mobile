/* [grial-metadata] id: Grial#NavigationFlatListPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class NavigationFlatListPage : ContentPage
    {
        public NavigationFlatListPage()
        {
            InitializeComponent();

            BindingContext = new NavigationViewModel(variantPageName: $"{GetType().Name}.xaml");
        }
    }
}
