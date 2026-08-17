/* [grial-metadata] id: Grial#ExplorerFlowNavigationPage.xaml version: 1.0.3 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class ExplorerFlowNavigationPage : NavigationPage
{
    public ExplorerFlowNavigationPage()
    {
        InitializeComponent();
    }

    public ExplorerFlowNavigationPage(Page root)
        : base(root)
    {
        InitializeComponent();
    }

    private async void OnClose(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
