/* [grial-metadata] id: Grial#WebsiteTrafficReportViewModel.cs version: 1.0.1 */
using System;
using System.Collections.ObjectModel;
using UXDivers.Grial;

namespace arabasorgula
{
	public class WebsiteTrafficReportViewModel: ObservableObject
	{
        private string _total;
        private int _maxValue;

        public WebsiteTrafficReportViewModel()
        {
            LoadData();
        }

        public ObservableCollection<WebsiteTrafficSeriesData> WebSiteSeries { get; } = new ObservableCollection<WebsiteTrafficSeriesData>();
        public ObservableCollection<WebsiteAcquisitionSeriesData> Acquisition { get; } = new ObservableCollection<WebsiteAcquisitionSeriesData>();
        public WebsiteTrafficData Users { get; set; }
        public WebsiteTrafficData Sessions { get; set; }

        public string Total
        {
            get { return _total; }
            set { SetProperty(ref _total, value); }
        }

        public int MaxValue
        {
            get { return _maxValue; }
            set { SetProperty(ref _maxValue, value); }
        }

        private void LoadData()

        {
            WebSiteSeries.Clear();
            Acquisition.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "DataViz.json");
        }
    }
}

