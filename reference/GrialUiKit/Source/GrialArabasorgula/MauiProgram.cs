/* [grial-metadata] id: Grial#MauiProgram.cs version: 2.1.6 */
using UXDivers.Grial;
using UXDivers.Grial.Maps;
using UXDivers.Popups.Maui;

namespace arabasorgula;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .UseGrial()
            .UseGrialMaps()
            .UseUXDiversPopups()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Poppins-Italic.ttf", "PoppinsItalic");
                fonts.AddFont("Poppins-SemiBoldItalic.ttf", "PoppinsSemiBoldItalic");
                fonts.AddFont("Poppins-SemiBold.ttf", "PoppinsSemiBold");
                fonts.AddFont("Poppins-Regular.ttf", "Poppins");
                fonts.AddFont("GrialIconsLine.ttf", "GrialIconsLine");
                fonts.AddFont("GrialIconsFill.ttf", "GrialIconsFill");
                fonts.AddFont("lucide.ttf", "lucide");
                fonts.AddFont("materialdesignicons-webfont.ttf", "Material Design Icons");
                fonts.AddFont("fa-brands-400-v6.ttf", "FontawesomeBrands");
                fonts.AddFont("fa-regular-400-v6.ttf", "FontawesomeRegular");
                fonts.AddFont("fa-solid-900-v6.ttf", "FontawesomeSolid");
                fonts.AddFont("line-awesome.ttf", "LineAwesome");
                fonts.AddFont("ionicons.ttf", "Ionicons");
            })
            .ConfigureMauiHandlers(handlers =>
            {
                handlers.AddHandler<Entry, UXDivers.Grial.EntryHandler>();
                handlers.AddHandler<Editor, UXDivers.Grial.EditorHandler>();
                handlers.AddHandler<Picker, UXDivers.Grial.PickerHandler>();
                handlers.AddHandler<DatePicker, UXDivers.Grial.DatePickerHandler>();
                handlers.AddHandler<TimePicker, UXDivers.Grial.TimePickerHandler>();
                handlers.AddHandler<NavigationPage, UXDivers.Grial.GrialNavigationPageHandler>();
                handlers.AddHandler<Image, UXDivers.Grial.ImageHandler>();
                handlers.AddHandler<Switch, UXDivers.Grial.SwitchHandler>();
                handlers.AddHandler<ScrollView, arabasorgula.ScrollViewHandler>();

#if IOS || MACCATALYST
                handlers.AddHandler<Microsoft.Maui.Controls.CollectionView, Microsoft.Maui.Controls.Handlers.Items2.CollectionViewHandler2>();
                handlers.AddHandler<Microsoft.Maui.Controls.CarouselView, Microsoft.Maui.Controls.Handlers.Items2.CarouselViewHandler2>();
#endif
            });

#pragma warning disable CA1416 // Validate platform compatibility
        CommunityToolkit.Maui.AppBuilderExtensions.UseMauiCommunityToolkit(builder);
#pragma warning restore CA1416 // Validate platform compatibility

        return builder.Build();
    }
}
