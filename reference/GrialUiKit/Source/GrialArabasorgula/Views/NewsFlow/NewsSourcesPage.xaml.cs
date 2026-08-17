/* [grial-metadata] id: Grial#NewsSourcesPage.cs version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class NewsSourcesPage : ContentPage
{
	public NewsSourcesPage()
	{
		InitializeComponent();

        BindingContext = new NewsSourcesViewModel(Navigation);
    }
}
