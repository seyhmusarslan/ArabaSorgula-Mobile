/* [grial-metadata] id: Grial#WizardNavigationPage.xaml version: 1.0.3 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class WizardNavigationPage : NavigationPage
{
    public WizardNavigationPage()
    {
        InitializeComponent();
    }

    public WizardNavigationPage(Page root)
    : base(root)
    {
        InitializeComponent();
    }

    private async void OnClose(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
