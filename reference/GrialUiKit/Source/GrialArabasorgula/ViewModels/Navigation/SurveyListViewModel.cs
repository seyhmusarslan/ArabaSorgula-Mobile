/* [grial-metadata] id: Grial#SurveyListViewModel.cs version: 1.0.5 */
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
	public class SurveyListViewModel: ObservableObject
	{
        public SurveyListViewModel()
             : base(listenCultureChanges: true)
        {
            LoadData();
        }

        public ObservableCollection<SurveyData> SurveyCategories { get; } = new ObservableCollection<SurveyData>();
        public ObservableCollection<SurveyListData> SurveyList { get; } = new ObservableCollection<SurveyListData>();

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            SurveyCategories.Clear();
            SurveyList.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Navigation.json");
        }
    }
}
