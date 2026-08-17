/* [grial-metadata] id: Grial#NewsMembershipPage.cs version: 1.0.6 */
using Microsoft.Maui.Graphics.Text;
using UXDivers.Grial;

namespace arabasorgula;

public partial class NewsMembershipPage : ContentPage
{
	public NewsMembershipPage()
	{
		InitializeComponent();

        BindingContext = new NewsMembershipViewModel();
	}

    private async void ActivateButtonClicked(object sender, EventArgs e)
    {
        await DisplayAlertAsync("Demo App", "Thanks for buying! :)", "Ok");
        await Navigation.PopModalAsync();
    }

    private async void OnClose(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
