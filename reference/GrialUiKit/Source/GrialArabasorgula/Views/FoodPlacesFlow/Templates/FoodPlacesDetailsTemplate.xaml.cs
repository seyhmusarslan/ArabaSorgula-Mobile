/* [grial-metadata] id: Grial#FoodPlacesDetailsTemplate.xaml version: 2.0.6 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class FoodPlacesDetailsTemplate : ContentView
    {
        public FoodPlacesDetailsTemplate()
        {
            InitializeComponent();
        }

        private async void DishTapped(object sender, EventArgs e)
        {
            var view = sender as View;
            var viewModel = BindingContext as FoodPlacesMapViewModel;
            await Navigation.PushModalAsync(new FoodPlacesCarouselImagesPage(viewModel.FoodPlaceData.Dishes, view.BindingContext as string));
        }

        private async void RateClicked(object sender, EventArgs e)
        {
            var vm = BindingContext as FoodPlacesMapViewModel;
            await Navigation.PushAsync(new FoodPlacesDishReviewPage(vm.FoodPlaceData.HeaderImage));
        }
    }
}
