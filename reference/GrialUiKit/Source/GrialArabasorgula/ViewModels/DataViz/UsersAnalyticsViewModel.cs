/* [grial-metadata] id: Grial#UsersAnalyticsViewModel.cs version: 1.0.1 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UXDivers.Grial;

namespace arabasorgula
{
    public class UsersAnalyticsViewModel : ObservableObject
    {
        private string _selectedPeriod, _customerSelectedPeriod;
        private UserAnalyticsChartData _chartData;
        private UserAnalyticsSeriesData _selectedPeriodData;
        private UserAnalyticsAreaChartData _chartAreaData;
        private AnalyticsAreaSeriesData _selectedPeriodAreaData;

        public UsersAnalyticsViewModel()
        {
            LoadData();
        }

        public ObservableCollection<string> Periods { get; } = new ObservableCollection<string>();

        public UserAnalyticsChartData ChartData
        {
            get { return _chartData; }
            set { SetProperty(ref _chartData, value); }
        }

        public UserAnalyticsSeriesData SelectedPeriodData
        {
            get { return _selectedPeriodData; }
            set { SetProperty(ref _selectedPeriodData, value); }
        }

        public UserAnalyticsAreaChartData ChartAreaData
        {
            get { return _chartAreaData; }
            set { SetProperty(ref _chartAreaData, value); }
        }

        public AnalyticsAreaSeriesData SelectedPeriodAreaData
        {
            get { return _selectedPeriodAreaData; }
            set { SetProperty(ref _selectedPeriodAreaData, value); }
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
                        SelectedPeriodData = ChartData.LastMonth;
                    }
                    else if (value == Resx.AppResources.StringLastYear)
                    {
                        SelectedPeriodData = ChartData.LastYear;
                    }
                    else
                    {
                        SelectedPeriodData = ChartData.LastWeek;
                    }
                }
            }
        }

        public string CustomerSelectedPeriod
        {
            get { return _customerSelectedPeriod; }
            set
            {
                if (SetProperty(ref _customerSelectedPeriod, value))
                {
                    if (value == Resx.AppResources.StringLastMonth)
                    {
                        SelectedPeriodAreaData = ChartAreaData.LastMonth;
                    }
                    else if (value == Resx.AppResources.StringLastYear)
                    {
                        SelectedPeriodAreaData = ChartAreaData.LastYear;
                    }
                    else
                    {
                        SelectedPeriodAreaData = ChartAreaData.LastWeek;
                    }
                }
            }
        }

        private void LoadData()
        {
            Periods.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "DataViz.json");

            SelectedPeriod = Periods.FirstOrDefault();
            CustomerSelectedPeriod = Periods.FirstOrDefault();
        }
    }
}
