/* [grial-metadata] id: Grial#NewsSignUpPage.cs version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class NewsSignUpPage : ContentPage
{
	public NewsSignUpPage()
	{
		InitializeComponent();
	}

    private void CreateButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewsMainPage());
    }

    private void LoginButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewsLoginPage());
    }

    private void OnEyeTapped(object sender, TappedEventArgs e)
    {
        entry.IsPassword = !entry.IsPassword;
        icon.Text = entry.IsPassword ? MaterialCommunityIconsFont.EyeOutline : MaterialCommunityIconsFont.EyeOffOutline;
    }
}
