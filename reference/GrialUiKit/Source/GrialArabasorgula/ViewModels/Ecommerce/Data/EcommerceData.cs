/* [grial-metadata] id: Grial#EcommerceData.cs version: 1.1.5 */
using UXDivers.Grial;
namespace arabasorgula
{
    public class ProductData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public double RatingValue { get; set; }
        public double RatingMax { get; set; }
        public string Manufacturer { get; set; }
    }
    
    public class HotelBookingData
    {
        public string Name { get; set; }
        public double Rating { get; set; }
        public double Likes { get; set; }
        public double Comments { get; set; }
        public string Location { get; set; }
        public string Cost { get; set; }
    }
}
