/* [grial-metadata] id: Grial#NewExplorerItemPopupTemplate.xaml version: 2.0.6 */

using UXDivers.Popups.Maui;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula;

public partial class NewExplorerItemPopupTemplate : PopupPage
{
    public NewExplorerItemPopupTemplate(NewExplorerItemPopupViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }

    private async void OnTapped(object sender, EventArgs e)
    {
        await IPopupService.Current.PopAsync();
    }
}
