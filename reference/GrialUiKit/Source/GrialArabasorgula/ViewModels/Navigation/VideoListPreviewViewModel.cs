/* [grial-metadata] id: Grial#VideoListPreviewViewModel.cs version: 1.0.1 */
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class VideoListPreviewViewModel : ObservableObject
    {
        public VideoListPreviewViewModel()
            : base(listenCultureChanges: true)
        {
            LoadData();
        }

        public ObservableCollection<MovieData> Movies { get; } = new ObservableCollection<MovieData>();

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            Movies.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Navigation.json");
        }
    }
}
