/* [grial-metadata] id: Grial#DataVizData.cs version: 1.2.6 */
using UXDivers.Grial;
namespace arabasorgula
{
    public class ShipmentData
    {
        public string Id { get; set; }
        public string Icon { get; set; }
        public double Progress { get; set; }
        public string Time { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
    }

    public class TaskOverviewGroupData
    {
        public string Name { get; set; }
        public int Completed { get; set; }
        public int Remaining { get; set; }
        public string RemainingTasks => string.Format(Resx.AppResources.RemainingTasks, Remaining);
        public int[] Activity { get; set; }
    }

    public class BrowserTaskOverviewData
    {
        public string Title { get; set; }
        public int Total { get; set; }
        public int[] Evolution { get; set; }
    }

    public class BrowserPeopleTaskOverviewData
    {
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Division { get; set; }
        public double Change { get; set; }
        public int[] Evolution { get; set; }
    }

    public class DocumentTimelineEventData
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Icon { get; set; }
        public string When { get; set; }
        public bool IsInbound { get; set; }
    }

    // Analytics Active Users BarChart Series
    public class UserAnalyticsChartData
    {
        public UserAnalyticsSeriesData LastWeek { get; set; }
        public UserAnalyticsSeriesData LastMonth { get; set; }
        public UserAnalyticsSeriesData LastYear { get; set; }
    }

    public class UserAnalyticsSeriesData
    {
        public double MaxValue { get; set; }
        public double[] Europe { get; set; }
        public double[] Latam { get; set; }
        public double[] Asia { get; set; }
        public double[] Uk { get; set; }
    }

    // Analytics Customer Rate AreaChart Series
    public class UserAnalyticsAreaChartData
    {
        public string[] Labels { get; set; }
        public AnalyticsAreaSeriesData LastWeek { get; set; }
        public AnalyticsAreaSeriesData LastMonth { get; set; }
        public AnalyticsAreaSeriesData LastYear { get; set; }
    }

    public class AnalyticsAreaSeriesData
    {
        public double MaxValue { get; set; }
        public int[] FirstTime { get; set; }
        public int[] Recurring { get; set; }
    }

    //Analytics Traffic BarChart Series
    public class TrafficChartData
    {
        public TrafficSeriesData LastWeek { get; set; }
        public TrafficSeriesData LastMonth { get; set; }
        public TrafficSeriesData LastYear { get; set; }
    }

    public class TrafficSeriesData
    {
        public double ItemSeparation { get; set; }
        public double CategorySeparation { get; set; }
        public Entry[] FirstSeries { get; set; }
        public Entry[] SecondSeries { get; set; }
        public Data Organic { get; set; }
        public Data Paid { get; set; }

        public record Entry(string Label, double Value);
        public record Data(int Views, int Sold, int Overtime);
    }

    public class WalletChartData
    {
        public WalletSeriesData LastWeek { get; set; }
        public WalletSeriesData LastMonth { get; set; }
        public WalletSeriesData LastYear { get; set; }
    }

    public class WalletSeriesData
    {
        public string Remaining { get; set; }
        public string Income { get; set; }
        public string Expenses { get; set; }
        public WalletEntryData[] Transactions { get; set; }
    }

    public class WalletEntryData
    {
        public string Icon { get; set; }
        public string BackgroundColor { get; set; }
        public string Item { get; set; }
        public string Category { get; set; }
        public double Value { get; set; }
        public int ValueDifference { get; set; }

        //Workaround with binding colors on MAUI
        public Color BackgroundColorColor => Color.FromArgb(BackgroundColor);
    }

    public class WalletAreaChartData
    {
        public string[] Labels { get; set; }
        public int[] FirstValue { get; set; }
        public int[] SecondValue { get; set; }
    }

    public class ElectricitySeriesData
    {
        public string Label { get; set; }
        public int Value { get; set; }
    }

    public class ElectricityData
    {
        public string Value { get; set; }
        public string Percentage { get; set; }
        public int Difference { get; set; }
    }

    public class ElectricityUsageData
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public string Amount { get; set; }
    }

    public class WebsiteTrafficData
    {
        public string Icon { get; set; }
        public string ID { get; set; }
        public string Value { get; set; }
        public string Percentage { get; set; }
        public int Difference { get; set; }
    }

    public class WebsiteTrafficSeriesData
    {
        public string Label { get; set; }
        public int NonRecurringValue { get; set; }
        public int RecurringValue { get; set; }
    }

    public class WebsiteAcquisitionSeriesData
    {
        public string Label { get; set; }
        public int Value { get; set; }
    }

    public class SocialRankingUserData
    {
        public string UserImage { get; set; }
        public string UserName { get; set; }
        public string MemberSince { get; set; }
        public string Subscription { get; set; }
    }

    public class SocialRankingSocialData
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Views { get; set; }
        public string Likes { get; set; }
        public string Subs { get; set; }
    }

    public class RankingData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public string Year { get; set; }
        public string PosterImage { get; set; }
        public string RatingLabel { get; set; }
    }
}
