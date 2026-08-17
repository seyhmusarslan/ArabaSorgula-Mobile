using UXDivers.Grial;
namespace arabasorgula
{
    public partial class RootFlyoutPage : FlyoutPage
    {
        public RootFlyoutPage()
        {
            InitializeComponent();

            Flyout = new MainMenuPage(LaunchPageInDetail);
        }

        private async void LaunchPageInDetail(Page page)
        {
            Detail = page;
            IsPresented = false;
        }
    }
}