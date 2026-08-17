/* [grial-metadata] id: Grial#StartVariantPage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class StartVariantPage : ContentPage
{
	public StartVariantPage()
	{
		InitializeComponent();
	}

    private async void OnClose(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

}
