/* [grial-metadata] id: Grial#VideoCarouselHighlightsViewModel.cs version: 1.0.1 */
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class VideoCarouselHighlightsViewModel : ObservableObject
    {
        private readonly INavigation _navigation;

        public VideoCarouselHighlightsViewModel(INavigation navigation)
            : base(listenCultureChanges: true)
        {
            _navigation = navigation;

            LoadData();
        }

        public ICommand CloseCommand => new Command(OnCloseCommand);

        public string BackgroundVideo { get; set; }

        public ObservableCollection<HighlightData> Highlights { get; } = new ObservableCollection<HighlightData>();

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            Highlights.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Onboardings.json");
        }

        private void OnCloseCommand()
        {
            if (_navigation.ModalStack.Count > 0)
            {
                _navigation.PopModalAsync();
            }
        }
    }
}
