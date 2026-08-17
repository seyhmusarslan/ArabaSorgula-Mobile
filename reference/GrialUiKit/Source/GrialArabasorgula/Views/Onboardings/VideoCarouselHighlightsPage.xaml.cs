/* [grial-metadata] id: Grial#VideoCarouselHighlightsPage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class VideoCarouselHighlightsPage : ContentPage
{
	public VideoCarouselHighlightsPage()
	{
		InitializeComponent();

        BindingContext = new VideoCarouselHighlightsViewModel(Navigation);
    }
}
