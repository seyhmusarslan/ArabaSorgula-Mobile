/* [grial-metadata] id: Grial#DeleteConfirmationPopupTemplate.xaml version: 2.0.6 */

using UXDivers.Popups.Maui;
using UXDivers.Grial;

namespace arabasorgula;

public partial class DeleteConfirmationPopupTemplate : PopupPage
{
    public DeleteConfirmationPopupTemplate(DeleteConfirmationPopupViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }
}
