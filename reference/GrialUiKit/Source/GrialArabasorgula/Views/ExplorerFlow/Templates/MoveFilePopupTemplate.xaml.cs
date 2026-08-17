/* [grial-metadata] id: Grial#MoveFilePopupTemplate.xaml version: 2.0.6 */
using UXDivers.Popups.Maui;
using UXDivers.Grial;

namespace arabasorgula;

public partial class MoveFilePopupTemplate : PopupPage
{
    public MoveFilePopupTemplate(MoveFilePopupViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }
}
