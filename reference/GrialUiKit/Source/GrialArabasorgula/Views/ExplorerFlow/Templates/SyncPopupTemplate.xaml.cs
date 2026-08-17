/* [grial-metadata] id: Grial#SyncPopupTemplate.xaml version: 2.1.6 */

using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula;

public partial class SyncPopupTemplate
{
    public SyncPopupTemplate()
    {
        InitializeComponent();

        BindingContext = this;
    }

    public override void OnAppearing()
    {
        base.OnAppearing();

        progressBar.ProgressTo(1, 5000, Easing.CubicIn);
    }

    private async void OnProgressChanged(object sender, ValueChangedEventArgs e)
    {
        if (e.NewValue >= 1)
        {
            await IPopupService.Current.PopAsync(this);
        }
    }
}
