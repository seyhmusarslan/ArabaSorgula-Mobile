/* [grial-metadata] id: Grial#NewsMembershipViewModel.cs version: 1.0.1 */
using System;
using System.Collections.ObjectModel;
using UXDivers.Grial;

namespace arabasorgula
{
	public class NewsMembershipViewModel : ObservableObject
	{
        private NewsMembershipPlan _selectedPlan;

		public NewsMembershipViewModel()
		{
			LoadData();
		}

		public ObservableCollection<NewsMembershipPlan> Plans { get; } = new ObservableCollection<NewsMembershipPlan>();
        
		public NewsMembershipPlan SelectedPlan
		{
			get => _selectedPlan;
			set => SetProperty(ref _selectedPlan, value);
		}

		private void LoadData()
 		{
            Plans.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "News.json");

			SelectedPlan = Plans?.FirstOrDefault();
        }
    }
}

