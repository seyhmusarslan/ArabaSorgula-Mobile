/* [grial-metadata] id: Grial#ThemeData.cs version: 2.1.6 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public class TestimonialData
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Testimonial { get; set; }
        public string CompanyLogo { get; set; }
        public double Rating { get; set; }
    }

    public class ActionData
    {
        public string Icon { get; set; }
        public string Label { get; set; }
    }

    public class FAQData
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
    
    public class ShippingAppData
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Emoji { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Items { get; set; }
        public string Cost { get; set; }
        public string Status { get; set; }
        public string StepIcon { get; set; }
        public string StepTitle { get; set; }
    }
    
    public class PopupsData
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Type { get; set; }        
    }
    
    //ListActionPopup
    public class ListActionItem 
    {
        public string UserImage { get; set; }
    
        public string User { get; set; }
    
        public string UserActivity { get; set; }
    
        public bool IsSelected { get; set; }
    }

    
}
