using UXDivers.Grial;

namespace ArabaSorgula.Mobile;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .UseGrial();

        return builder.Build();
    }
}
