/* [grial-metadata] id: Grial#SocialRankingPage.xaml version: 1.0.6 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class SocialRankingPage : ContentPage
{
	public SocialRankingPage()
	{
		InitializeComponent();

        BindingContext = new SocialRankingViewModel();
    }
}
