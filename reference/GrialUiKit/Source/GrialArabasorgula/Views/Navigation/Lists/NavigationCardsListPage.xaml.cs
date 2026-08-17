/* [grial-metadata] id: Grial#NavigationCardsListPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class NavigationCardsListPage : ContentPage
    {
        public NavigationCardsListPage()
        {
            InitializeComponent();

            BindingContext = new NavigationViewModel(variantPageName: $"{GetType().Name}.xaml");
        }
    }
}
