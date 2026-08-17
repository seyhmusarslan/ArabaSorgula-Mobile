/* [grial-metadata] id: Grial#NewsWelcomePage.cs version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class NewsWelcomePage : ContentPage
{
	public NewsWelcomePage()
	{
		InitializeComponent();
	}

    private void SignUpButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewsSignUpPage());
    }

    private void LoginButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewsLoginPage());
    }
}
