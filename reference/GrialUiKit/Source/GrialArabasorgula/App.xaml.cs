/* [grial-metadata] id: Grial#App.xaml version: 2.4.6 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Localization:
        //
        // Use "DefaultStringResources" key to define the default Resx type and get
        // the most compact version of the Translation Xaml extension like this:
        //
        // <Label Text="{ grial:Translate MyStringKey }" />
        //
        // Optionally:
        // <Label Text="{ grial:Translate Key=MyStringKey }" />
        //
        // To use another named Resx you can use either:
        // 
        // a) define the namspace of the Resx type, for instance:
        //    xmlns:resx="clr-namespace:Grial.Maui"
        //
        //    and use it like this:
        //    <Label Text="{ grial:Translate Key=resx:OtherResources.MyStringKey }" />
        //
        //  b) define a StaticResource as an instance of the Resx type
        //     <resx:OtherResources x:Key="MyOtherResourcesKey" />
        //
        //     and use it like this:
        //     <Label Text="{ grial:Translate Key=MyStringKey, Source={ StaticResource MyOtherResourcesKey } }" />
        //
        // Note: The Extension supports both Converter and StringFormat properties
        // as regular Bindings do. 
        Resources["DefaultStringResources"] = new Resx.AppResources();
        
        SamplesCatalog.Initialize();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        var mainPage = GetMainPage();

        return new Window(mainPage);
    }

    private static Page GetMainPage()
    {
        return new RootFlyoutPage();
    }
}
