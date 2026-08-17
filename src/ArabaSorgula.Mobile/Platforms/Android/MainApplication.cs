using Android.App;
using Android.Runtime;
using UXDivers.Grial;

namespace ArabaSorgula.Mobile;

[Application]
public class MainApplication : MauiApplication
{
    public MainApplication(nint handle, JniHandleOwnership ownership)
        : base(handle, ownership)
    {
    }

    protected override MauiApp CreateMauiApp()
    {
        GrialKit.Init("ArabaSorgula.Mobile.GrialLicense");

        return MauiProgram.CreateMauiApp();
    }
}
