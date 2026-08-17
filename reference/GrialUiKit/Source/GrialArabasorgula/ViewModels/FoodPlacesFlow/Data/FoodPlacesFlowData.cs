/* [grial-metadata] id: Grial#FoodPlacesFlowData.cs version: 1.0.1 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public class FoodPlaceData
    {
        private double _latitude = 0;
        private double _longitude = 0;

        public string Image { get; set; }
        public string HeaderImage { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }
        public string Description { get; set; }
        public bool IsOpen { get; set; }
        public double Rating { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
        public string Distance { get; set; }
        public List<TrafficInformation> TrafficInformation { get; set; }
        public List<Review> Reviews { get; set; }
        public int ReviewsCount { get; set; }
        public List<string> Dishes { get; set; }
        public int DishesCount { get; set; }
        public Location Position { get; set; }

        public double Latitude
        {
            get => _latitude;
            set
            {
                if (value != _latitude)
                {
                    _latitude = value;
                    Position = new Location(_latitude, _longitude);
                }
            }
        }

        public double Longitude
        {
            get => _longitude;
            set
            {
                if (value != _longitude)
                {
                    _longitude = value;
                    Position = new Location(_latitude, _longitude);
                }
            }
        }
    }

    public class Review
    {
        public string Name { get; set; }
        public string Avatar { get; set; }
        public double Rating { get; set; }
        public string Date { get; set; }
        public string Text { get; set; }
    }

    public class TrafficInformation
    {
        public string IconText { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class RateCategory
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Rate { get; set; }
    }
}
