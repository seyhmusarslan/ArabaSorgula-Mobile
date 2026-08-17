/* [grial-metadata] id: Grial#SocialRankingViewModel.cs version: 1.0.6 */
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
	public class SocialRankingViewModel :ObservableObject
	{
		public SocialRankingViewModel()
              : base(listenCultureChanges: true)
        {
            LoadData();
        }
       
        public ObservableCollection<SocialRankingSocialData> SocialData { get; } = new ObservableCollection<SocialRankingSocialData>();

        public SocialRankingUserData UserData { get; set; }

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {            
            SocialData.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "DataViz.json");
          
        }
    }
}

