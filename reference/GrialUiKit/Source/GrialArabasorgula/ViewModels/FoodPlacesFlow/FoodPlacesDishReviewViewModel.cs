/* [grial-metadata] id: Grial#FoodPlacesDishReviewViewModel.cs version: 1.0.1 */
using System;
using System.Collections.ObjectModel;
using UXDivers.Grial;

namespace arabasorgula
{
    public class FoodPlacesDishReviewViewModel : ObservableObject
    {
        public FoodPlacesDishReviewViewModel(string dish)
        {
            LoadData();

            SelectedDishImage = dish;
        }

        public ObservableCollection<string> ExperienceRates { get; } = new ObservableCollection<string>();
        public ObservableCollection<string> ImprovedCategories { get; } = new ObservableCollection<string>();
        public ObservableCollection<RateCategory> RateCategories { get; } = new ObservableCollection<RateCategory>();
        public string SelectedDishImage { get; set; }

        private void LoadData()
        {
            ExperienceRates.Clear();
            ImprovedCategories.Clear();
            RateCategories.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "FoodPlacesFlow.json");
        }
    }
}
