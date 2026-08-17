/* [grial-metadata] id: Grial#MediaRankingPage.xaml version: 1.0.6 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class MediaRankingPage : ContentPage
{
    public MediaRankingPage()
    {
        InitializeComponent();

        BindingContext = new MediaRankingViewModel(Navigation);
    }
}
