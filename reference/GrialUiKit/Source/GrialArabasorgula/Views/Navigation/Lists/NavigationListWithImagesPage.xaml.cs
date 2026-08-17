/* [grial-metadata] id: Grial#NavigationListWithImagesPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class NavigationListWithImagesPage : ContentPage
    {
        public NavigationListWithImagesPage()
        {
            InitializeComponent();

            BindingContext = new NavigationViewModel(variantPageName: $"{GetType().Name}.xaml");
        }
    }
}
