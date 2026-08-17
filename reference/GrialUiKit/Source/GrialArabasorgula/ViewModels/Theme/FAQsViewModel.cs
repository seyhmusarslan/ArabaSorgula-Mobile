/* [grial-metadata] id: Grial#FAQsViewModel.cs version: 1.0.1 */
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class FAQsViewModel : ObservableObject
    {
        public FAQsViewModel()
            : base(listenCultureChanges: true)
        {
            LoadData();
        }

        public ObservableCollection<FAQData> FAQsList { get; } = new ObservableCollection<FAQData>();

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            FAQsList.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Theme.json");
        }
    }
}