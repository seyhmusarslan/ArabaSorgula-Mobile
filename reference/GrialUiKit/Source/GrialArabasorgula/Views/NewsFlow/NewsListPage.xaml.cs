/* [grial-metadata] id: Grial#NewsListPage.cs version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class NewsListPage : ContentPage
{
	public NewsListPage()
	{
		InitializeComponent();

        BindingContext = new NewsListViewModel(Navigation);
    }
}
