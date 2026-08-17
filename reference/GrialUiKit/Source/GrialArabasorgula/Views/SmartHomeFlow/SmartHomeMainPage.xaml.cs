/* [grial-metadata] id: Grial#SmartHomeMainPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class SmartHomeMainPage : ContentPage
    {
        public SmartHomeMainPage()
        {
            InitializeComponent();

            BindingContext = new SmartHomeMainViewModel(Navigation);
        }
    }
}