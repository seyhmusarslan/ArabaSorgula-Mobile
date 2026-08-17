/* [grial-metadata] id: Grial#PaywallData.cs version: 1.0.3 */
using UXDivers.Grial;
namespace arabasorgula
{
    public class PlanItemDataA
    {
        public string PlanType { get; set; }
        public string PlanTag { get; set; }
        public string Savings { get; set; }
        public string FreeTrial { get; set; }
        public string OriginalPrice { get; set; }
        public string PriceOffer { get; set; }
        public string PlanBilling { get; set; }
    }

    public class PlanItemDataB
    {
        public string PlanType { get; set; }
        public string PlanCost { get; set; }
        public string MonthlyCost { get; set; }
        public string SavingsAmount { get; set; }
        public bool HasSavings{ get; set; }
        public Benefit[] Benefits { get; set; }
        public string[] AdditionalBenefits { get; set; }

        public class Benefit
        {
            public string Icon { get; set; }
            public string IconBackground { get; set; }
            public string Description { get; set; }
        }
    }

    public class PlanItemDataC
    {
        public string PlanName { get; set; }
        public string PlanPrice { get; set; }
        public bool InlcudesFeature1 { get; set; }        
        public bool InlcudesFeature2 { get; set; }
        public bool InlcudesFeature3 { get; set; }
        public bool InlcudesFeature4 { get; set; }
    }

    public class PlanItemDataD
    {
        public string PlanType { get; set; }
        public string PlanCost { get; set; }
        public string Benefit { get; set; }
        public string BillingDescription { get; set; }
        public string MonthlyCost { get; set; }
        public bool IsBestDeal { get; set; }
    }  
}
