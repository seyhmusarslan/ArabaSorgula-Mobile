/* [grial-metadata] id: Grial#WalletAlternativePage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class WalletAlternativePage : ContentPage
{
	public WalletAlternativePage()
	{
		InitializeComponent();

		BindingContext = new WalletAlternativeViewModel();
	}
}
