using Foundation;
using UIKit;
using UXDivers.Grial;

namespace arabasorgula;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp()
	{
		var theme = new ThemeColorsBase(new Dictionary<string, Color>
		{
			{ "AccentColor", Color.FromArgb("#FF3F75FF") }
		});

		GrialKit.Init(theme, "arabasorgula.GrialLicense");

		return MauiProgram.CreateMauiApp();
	}
	
	[Export("application:supportedInterfaceOrientationsForWindow:")]
	public UIInterfaceOrientationMask GetSupportedInterfaceOrientations(UIApplication application, UIWindow forWindow)
	{
		return GrialKit.GetSupportedInterfaceOrientations(application, forWindow);
	}
}
