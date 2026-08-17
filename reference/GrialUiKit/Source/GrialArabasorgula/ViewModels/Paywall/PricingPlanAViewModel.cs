/* [grial-metadata] id: Grial#PricingPlanAViewModel.cs version: 1.1.6 */
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class PricingPlanAViewModel : ObservableObject
    {
        private PlanItemDataA _selectedPlan;

        public PricingPlanAViewModel()
            : base(listenCultureChanges: true)
        {
            ContinueCommand = new Command(OnContinue);

            LoadData();
        }

        public ICommand ContinueCommand { get;}

        public ObservableCollection<PlanItemDataA> Plans { get; } = new ObservableCollection<PlanItemDataA>();

        public PlanItemDataA SelectedPlan
        {
            get => _selectedPlan;
            set => SetProperty(ref _selectedPlan, value);
        }

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            Plans.Clear();
            SelectedPlan = null;

            JsonHelper.Instance.LoadViewModel(this, source: "Paywall.json");

            SelectedPlan = Plans?.FirstOrDefault();
        }

        private void OnContinue()
        {
            if (Application.Current == null || Application.Current.Windows.Count == 0)
            {
                return;
            }

            Application.Current.Windows[0]?.Page.DisplayAlertAsync("Demo!", $"Thanks for picking {SelectedPlan?.PlanType} plan :)", "OK");
        }
    }
}