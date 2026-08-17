/* [grial-metadata] id: Grial#FoodPlacesMapViewModel.cs version: 1.0.1 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UXDivers.Grial;

namespace arabasorgula
{
    public class FoodPlacesMapViewModel : ObservableObject
    {
        public FoodPlacesMapViewModel(FoodPlaceData foodPlaceData)
        {
            FoodPlaceData = foodPlaceData;
            FoodPlaceItemsSource = new List<FoodPlaceData> { FoodPlaceData };
        }

        public FoodPlaceData FoodPlaceData { get; private set; }

        public List<FoodPlaceData> FoodPlaceItemsSource { get; private set; }
    }
}