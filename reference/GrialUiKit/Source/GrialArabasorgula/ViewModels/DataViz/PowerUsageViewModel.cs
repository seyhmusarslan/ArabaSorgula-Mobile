/* [grial-metadata] id: Grial#PowerUsageViewModel.cs version: 1.0.1 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UXDivers.Grial;

namespace arabasorgula
{
    public class PowerUsageViewModel : ObservableObject
    {
        private int _maxValue;

        public PowerUsageViewModel()
        {
            LoadData();
        }

        public ObservableCollection<ElectricitySeriesData> ElectricitySeries { get; } = new ObservableCollection<ElectricitySeriesData>();
        public ObservableCollection<ElectricityUsageData> DeviceUsage { get; } = new ObservableCollection<ElectricityUsageData>();
        public ElectricityData Amount { get; set; }
        public ElectricityData Cost { get; set; }

        public int MaxValue
        {
            get { return _maxValue; }
            set { SetProperty(ref _maxValue, value); }
        }

        private void LoadData()

        {
            ElectricitySeries.Clear();
            DeviceUsage.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "DataViz.json");
        }
    }
}

