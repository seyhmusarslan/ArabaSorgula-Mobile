/* [grial-metadata] id: Grial#DocumentTimelineViewModel.cs version: 1.0.1 */
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class DocumentTimelineViewModel : ObservableObject
    {
        public DocumentTimelineViewModel()
            : base(listenCultureChanges: true)
        {
            LoadData();
        }

        public ObservableCollection<DocumentTimelineEventData> DocumentTimelineList { get; } = new ObservableCollection<DocumentTimelineEventData>();

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            DocumentTimelineList.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "DataViz.json");
        }
    }
}
