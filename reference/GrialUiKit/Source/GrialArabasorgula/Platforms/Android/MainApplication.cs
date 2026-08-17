using Android.App;
using Android.Runtime;
using UXDivers.Grial;

namespace arabasorgula;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp()
	{
		GrialKit.Init("arabasorgula.GrialLicense");

		return MauiProgram.CreateMauiApp();
	}
}
