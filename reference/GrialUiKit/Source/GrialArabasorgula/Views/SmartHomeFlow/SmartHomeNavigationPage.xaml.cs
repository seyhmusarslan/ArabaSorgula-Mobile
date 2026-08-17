/* [grial-metadata] id: Grial#SmartHomeNavigationPage.xaml version: 1.0.4 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class SmartHomeNavigationPage : NavigationPage
    {
        public SmartHomeNavigationPage()
        {
        }

        public SmartHomeNavigationPage(Page root)
            : base(root)
        {
            InitializeComponent();
        }

        private async void OnClose(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
