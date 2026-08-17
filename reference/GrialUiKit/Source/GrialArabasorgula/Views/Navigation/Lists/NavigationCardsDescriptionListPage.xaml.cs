/* [grial-metadata] id: Grial#NavigationCardsDescriptionListPage.xaml version: 1.0.3 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class NavigationCardsDescriptionListPage : ContentPage
    {
        public NavigationCardsDescriptionListPage()
        {
            InitializeComponent();

            BindingContext = new NavigationViewModel(variantPageName: $"{GetType().Name}.xaml");
        }
    }
}
