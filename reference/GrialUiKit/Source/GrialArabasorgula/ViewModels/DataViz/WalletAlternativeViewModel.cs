/* [grial-metadata] id: Grial#WalletAlternativeViewModel.cs version: 1.0.1 */
using System;
using System.Collections.ObjectModel;
using UXDivers.Grial;

namespace arabasorgula
{
	public class WalletAlternativeViewModel : ObservableObject
	{   
        private WalletAreaChartData _chartAreaData;
        private string _income, _expenses;

        public WalletAlternativeViewModel()
            : base(listenCultureChanges: true)
        {
            LoadData();
        }

        public WalletAreaChartData ChartAreaData
        {
            get { return _chartAreaData; }
            set { SetProperty(ref _chartAreaData, value); }
        }

        public ObservableCollection<WalletEntryData> Transactions { get; } = new ObservableCollection<WalletEntryData>();

        public string Income
        {
            get { return _income; }
            set { SetProperty(ref _income, value); }
        }

        public string Expenses
        {
            get { return _expenses; }
            set { SetProperty(ref _expenses, value); }
        }

        private void LoadData()
        {
            Transactions.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "DataViz.json");
        }
    }
}

