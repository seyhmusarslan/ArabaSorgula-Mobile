/* [grial-metadata] id: Grial#TasksFlowData.cs version: 1.0.6 */
using UXDivers.Grial;
namespace arabasorgula
{
    public class FlowTasksData
    {
        public FlowRingSeriesData LastWeek { get; set; }
        public FlowRingSeriesData LastMonth { get; set; }
        public FlowRingSeriesData LastYear { get; set; }
    }

    public class FlowRingSeriesData
    {
        public FlowRingData[] RingSeries { get; set; }
    }

    public class FlowRingData
    {
        public int Value { get; set; }
        public string ValueLabel { get; set; }
        public string Label { get; set; }
        public string Color { get; set; }

        public Color ColorColor => Microsoft.Maui.Graphics.Color.FromArgb(Color);
    }

    public class FlowChartData
    {
        public FlowSeriesData LastWeek { get; set; }
        public FlowSeriesData LastMonth { get; set; }
        public FlowSeriesData LastYear { get; set; }
    }

    public class FlowSeriesData
    {
        public int MaxValue { get; set; }
        public List<int> MaxValues => new List<int>(Enumerable.Repeat(MaxValue, Series.Count()));
        public FlowEntryData[] Series { get; set; }
    }

    public class FlowEntryData
    {
        public int Value { get; set; }
        public int Value2 { get; set; }
        public string Label { get; set; }
        public string Color { get; set; }
        public string ValueLabelColor { get; set; }

        public Color ColorColor => Microsoft.Maui.Graphics.Color.FromArgb(Color);
    }

    public class FlowEmployeeData
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                var parts = _name.Split(' ');
                FirstName = parts.ElementAtOrDefault(0);
                LastName = parts.ElementAtOrDefault(1);
            }
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Avatar { get; set; }
        public string Status { get; set; }
        public string Team { get; set; }
        public int Open { get; set; }
        public int Closed { get; set; }
        public int Score { get; set; }
        public string ScoreLabel { get; set; }
        public string[] Tags { get; set; }
    }

    public class FlowMetricData
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public int ValueDifference { get; set; }
    }
}
