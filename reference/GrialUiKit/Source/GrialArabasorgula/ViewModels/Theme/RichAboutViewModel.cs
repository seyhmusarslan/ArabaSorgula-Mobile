/* [grial-metadata] id: Grial#RichAboutViewModel.cs version: 1.0.1 */
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class RichAboutViewModel : ObservableObject
    {
        public RichAboutViewModel()
            : base(listenCultureChanges: true)
        {
            LoadData();
        }
        
        public ObservableCollection<TestimonialData> Testimonials { get; } = new ObservableCollection<TestimonialData>();

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            Testimonials.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Theme.json");
        }
    }
}
