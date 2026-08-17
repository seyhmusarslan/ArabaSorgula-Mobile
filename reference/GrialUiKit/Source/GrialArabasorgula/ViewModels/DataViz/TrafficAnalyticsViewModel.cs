/* [grial-metadata] id: Grial#TrafficAnalyticsViewModel.cs version: 1.0.1 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UXDivers.Grial;

namespace arabasorgula
{
    public class TrafficAnalyticsViewModel : ObservableObject
    {
        private string _selectedPeriod;
        private TrafficChartData _trafficChartData;
        private TrafficSeriesData _selectedPeriodData;

        public TrafficAnalyticsViewModel()
        {
            LoadData();
        }

        public ObservableCollection<string> Periods { get; } = new ObservableCollection<string>();

        public TrafficChartData TrafficChartData
        {
            get { return _trafficChartData; }
            set { SetProperty(ref _trafficChartData, value); }
        }

        public TrafficSeriesData SelectedPeriodData
        {
            get { return _selectedPeriodData; }
            set { SetProperty(ref _selectedPeriodData, value); }
        }

        public string SelectedPeriod
        {
            get { return _selectedPeriod; }
            set
            {
                if (SetProperty(ref _selectedPeriod, value))
                {
                    if (value == Resx.AppResources.StringLastMonth)
                    {
                        SelectedPeriodData = TrafficChartData.LastMonth;
                    }
                    else if (value == Resx.AppResources.StringLastYear)
                    {
                        SelectedPeriodData = TrafficChartData.LastYear;
                    }
                    else
                    {
                        SelectedPeriodData = TrafficChartData.LastWeek;
                    }
                }
            }
        }

        private void LoadData()
        {
            Periods.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "DataViz.json");

            SelectedPeriod = Periods.FirstOrDefault();
        }
    }
}
