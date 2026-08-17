/* [grial-metadata] id: Grial#NewsSourceProfilePage.cs version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class NewsSourceProfilePage : ContentPage
{
	public NewsSourceProfilePage()
	{
		InitializeComponent();

        BindingContext = new NewsSourceProfileViewModel();
    }
}
