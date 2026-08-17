/* [grial-metadata] id: Grial#ListWithColumnsVariantPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class ListWithColumnsVariantPage : ContentPage
    {
        public ListWithColumnsVariantPage()
        {
            InitializeComponent();
            BindingContext = new DashboardViewModel(variantPageName: $"{GetType().Name}.xaml");
        }
    }
}
