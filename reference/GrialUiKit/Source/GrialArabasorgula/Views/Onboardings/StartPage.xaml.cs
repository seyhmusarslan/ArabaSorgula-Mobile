/* [grial-metadata] id: Grial#StartPage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

    private async void OnClose(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

}
