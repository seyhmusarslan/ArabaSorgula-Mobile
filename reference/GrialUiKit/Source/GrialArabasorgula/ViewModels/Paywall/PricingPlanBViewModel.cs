/* [grial-metadata] id: Grial#PricingPlanBViewModel.cs version: 1.1.6 */
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class PricingPlanBViewModel : ObservableObject
    {
        private PlanItemDataB _selectedPlan;

        public PricingPlanBViewModel()
            : base(listenCultureChanges: true)
        {
            SubscribeCommand = new Command(OnSubscribe);

            LoadData();
        }

        public ICommand SubscribeCommand { get; }

        public ObservableCollection<PlanItemDataB> Plans { get; } = new ObservableCollection<PlanItemDataB>();

        public PlanItemDataB SelectedPlan
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

        private void OnSubscribe()
        {
            if (Application.Current == null || Application.Current.Windows.Count == 0)
            {
                return;
            }

            Application.Current?.Windows[0]?.Page.DisplayAlertAsync("Demo!", $"Thanks for picking {SelectedPlan?.PlanType} plan :)", "OK");
        }
    }
}

