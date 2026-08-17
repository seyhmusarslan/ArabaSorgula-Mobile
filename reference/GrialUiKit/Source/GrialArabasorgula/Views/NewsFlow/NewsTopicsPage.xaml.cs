/* [grial-metadata] id: Grial#NewsTopicsPage.cs version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class NewsTopicsPage : ContentPage
{
	public NewsTopicsPage()
	{
		InitializeComponent();

        BindingContext = new NewsTopicsViewModel();
    }
}
