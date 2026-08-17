/* [grial-metadata] id: Grial#FoodPlacesMainPage.xaml version: 1.0.1 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class FoodPlacesMainPage : ContentPage
    {
        public FoodPlacesMainPage()
        {
            InitializeComponent();

            BindingContext = new FoodPlacesMainViewModel();
        }

        private async void OnCardTapped(object sender, EventArgs e)
        {
            var place = (sender as View).BindingContext as FoodPlaceData;
            await Navigation.PushAsync(new FoodPlacesMapPage(place));
        }
    }
}
