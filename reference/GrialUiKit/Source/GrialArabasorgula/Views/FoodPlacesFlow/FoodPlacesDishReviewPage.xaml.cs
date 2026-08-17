/* [grial-metadata] id: Grial#FoodPlacesDishReviewPage.xaml version: 2.0.6 */

using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class FoodPlacesDishReviewPage : ContentPage
    {
        public FoodPlacesDishReviewPage()
        {
            InitializeComponent();

            BindingContext = new FoodPlacesDishReviewViewModel(new FoodPlacesMainViewModel().Places[0].Dishes[0]);
        }

        public FoodPlacesDishReviewPage(string dish)
        {
            InitializeComponent();

            BindingContext = new FoodPlacesDishReviewViewModel(dish);
        }

        private async void OnSubmit(object sender, EventArgs e)
        {
            var dialog = new NotificationPopup { Message = "Your review has been submitted!" };

            await IPopupService.Current.PushAsync(dialog);

            await Navigation.PopModalAsync();
        }

        private async void OnClose(object sender, EventArgs e)
        {
            if (Navigation.NavigationStack?.Count > 1)
            {
                await Navigation.PopAsync();
            }
            else
            {
                await Navigation.PopModalAsync();
            }
        }
    }
}
