/* [grial-metadata] id: Grial#ListWithColumnsPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class ListWithColumnsPage : ContentPage
    {
        public ListWithColumnsPage()
        {
            InitializeComponent();
            BindingContext = new DashboardViewModel(variantPageName: $"{GetType().Name}.xaml");
        }
    }
}
