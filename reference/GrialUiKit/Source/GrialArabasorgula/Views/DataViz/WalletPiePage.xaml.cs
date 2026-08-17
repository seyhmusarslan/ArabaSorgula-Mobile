/* [grial-metadata] id: Grial#WalletPiePage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class WalletPiePage : ContentPage
{
	public WalletPiePage()
	{
		InitializeComponent();

        BindingContext = new WalletPieViewModel();
    }
}
