/* [grial-metadata] id: Grial#NewsMainPage.cs version: 1.0.6 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class NewsMainPage : TabbedPage
{
	public NewsMainPage()
	{
		InitializeComponent();
	}

    private void OnProfileTapped(object sender, EventArgs e)
    {
		Navigation.PushAsync(new NewsMyProfilePage());
	}
}
