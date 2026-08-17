/* [grial-metadata] id: Grial#FoodPlacesMapPage.xaml version: 1.1.6 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class FoodPlacesMapPage
    {
        public FoodPlacesMapPage()
        {
            InitializeComponent();

            var mainViewModel = new FoodPlacesMainViewModel();
            BindingContext = new FoodPlacesMapViewModel(mainViewModel.Places[0]);
        }

        public FoodPlacesMapPage(FoodPlaceData place)
        {
            InitializeComponent();

            BindingContext = new FoodPlacesMapViewModel(place);
        }

        private void OnTapped(object sender, EventArgs e)
        {
            drawer.ChangePosition(1);
        }
    }
}
