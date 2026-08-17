/* [grial-metadata] id: Grial#WalletPieViewModel.cs version: 1.0.1 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class WalletPieViewModel : ObservableObject
    {
        private bool _week, _month, _year;
        private WalletChartData _walletChartData;
        private WalletSeriesData _selectedPeriodData;

        public WalletPieViewModel()
            : base(listenCultureChanges: true)
        {
            LoadData();
        }

        public ObservableCollection<string> Periods { get; } = new ObservableCollection<string>();
        
        public WalletChartData WalletChartData
        {
            get { return _walletChartData; }
            set { SetProperty(ref _walletChartData, value); }
        }

        public WalletSeriesData SelectedPeriodData
        {
            get { return _selectedPeriodData; }
            set { SetProperty(ref _selectedPeriodData, value); }
        }

        public bool Week
        {
            get { return _week; }
            set 
            {
                if (SetProperty(ref _week, value) && _week)
                {
                    SelectedPeriodData = WalletChartData.LastWeek;
                }
            }
        }
        public bool Month
        {
            get { return _month; }
            set 
            {
                if (SetProperty(ref _month, value) && _month)
                {
                    SelectedPeriodData = WalletChartData.LastMonth;
                }
            }
        }

        public bool Year
        {
            get { return _year; }
            set
            {
                if (SetProperty(ref _year, value) && _year)
                {
                    SelectedPeriodData = WalletChartData.LastYear;
                }
            }
        }

        private void LoadData()
        {
            Periods.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "DataViz.json");

            Week = true;
        }
    }
}
