/* [grial-metadata] id: Grial#NewsLoginPage.cs version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class NewsLoginPage : ContentPage
{
	public NewsLoginPage()
	{
		InitializeComponent();
	}

    private void LoginButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewsMainPage());
    }

    private void SignupButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewsSignUpPage());
    }

    private void OnEyeTapped(object sender, TappedEventArgs e)
    {
        entry.IsPassword = !entry.IsPassword;
        icon.Text = entry.IsPassword ? MaterialCommunityIconsFont.EyeOutline : MaterialCommunityIconsFont.EyeOffOutline;
    }
}
