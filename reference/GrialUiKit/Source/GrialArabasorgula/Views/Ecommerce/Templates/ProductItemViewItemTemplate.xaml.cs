/* [grial-metadata] id: Grial#ProductItemViewItemTemplate.xaml version: 1.0.3 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class ProductItemViewItemTemplate : ContentView
{
    public ProductItemViewItemTemplate()
    {
        InitializeComponent();
    }

    private async void OnImageTapped(object sender, EventArgs e)
    {
        var imagePreview = new ProductImageFullScreenPage((sender as Image).Source);

        await Navigation.PushModalAsync(new NavigationPage(imagePreview));
    }
}