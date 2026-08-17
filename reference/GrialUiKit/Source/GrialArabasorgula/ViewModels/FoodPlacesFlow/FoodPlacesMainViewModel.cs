/* [grial-metadata] id: Grial#FoodPlacesMainViewModel.cs version: 1.0.1 */
using System;
using System.Collections.ObjectModel;
using UXDivers.Grial;

namespace arabasorgula
{
    public class FoodPlacesMainViewModel : ObservableObject
    {
        public FoodPlacesMainViewModel()
        {
            LoadData();
        }

        public ObservableCollection<FoodPlaceData> Places { get; } = new ObservableCollection<FoodPlaceData>();

        private void LoadData()
        {
            Places.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "FoodPlacesFlow.json");
        }
    }
}
