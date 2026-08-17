/* [grial-metadata] id: Grial#ExplorerListPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class ExplorerListPage : ContentPage
{
    public ExplorerListPage()
    {
        InitializeComponent();

        BindingContext = new ExplorerFlowViewModel();
    }

    public ExplorerListPage(Folder folder)
    {
        InitializeComponent();

        BindingContext = new ExplorerFlowViewModel(folder);
    }

    private async void OnFolderTapped(object sender, EventArgs e)
    {
        if (sender is View view && view.BindingContext is Folder folder)
        {
            await Navigation.PushAsync(new ExplorerListPage(folder));
        }
    }
}
