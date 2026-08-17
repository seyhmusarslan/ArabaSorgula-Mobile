/* [grial-metadata] id: Grial#FoodPlacesCarouselImagesPage.xaml version: 1.0.1 */
using System;
using System.Collections.Generic;
using System.Linq;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class FoodPlacesCarouselImagesPage : ContentPage
    {
        public FoodPlacesCarouselImagesPage()
        {
            InitializeComponent();

            BindingContext = new FoodPlacesMainViewModel().Places[0].Dishes;
        }

        public FoodPlacesCarouselImagesPage(List<string> dishes, string dish)
        {
            BindingContext = dishes;

            SelectedDish = dishes.FirstOrDefault((item) => dish == item);

            InitializeComponent();
        }

        public string SelectedDish { get; private set; }

        private async void OnClose(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
