/* [grial-metadata] id: Grial#NewsMyProfilePage.cs version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class NewsMyProfilePage : ContentPage
{
	public NewsMyProfilePage()
	{
		InitializeComponent();

        BindingContext = new NewsMyProfileViewModel();
    }
}
