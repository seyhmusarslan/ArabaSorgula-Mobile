/* [grial-metadata] id: Grial#PricingPlanCViewModel.cs version: 1.1.6 */
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class PricingPlanCViewModel : ObservableObject
    {
        private PlanItemDataC _selectedPlan;

        public PricingPlanCViewModel()
            : base(listenCultureChanges: true)
        {
            StartTrialCommand = new Command(OnStartTrial);
            ContinueCommand = new Command(OnContinue);
            GoToTermsOfServiceCommand = new Command(OnGoToTermsOfService);

            LoadData();
        }

        public ICommand StartTrialCommand { get; }
        public ICommand ContinueCommand { get; }
        public ICommand GoToTermsOfServiceCommand { get; }
        
        public ObservableCollection<PlanItemDataC> Plans { get; } = new ObservableCollection<PlanItemDataC>();

        public PlanItemDataC SelectedPlan
        {
            get => _selectedPlan;
            set => SetProperty(ref _selectedPlan, value);
        }

        public ObservableCollection<string> Features { get; } = new ObservableCollection<string>();

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            Plans.Clear();
            Features.Clear();
            SelectedPlan = null;

            JsonHelper.Instance.LoadViewModel(this, source: "Paywall.json");

            SelectedPlan = Plans?.FirstOrDefault();
        }

        private void OnStartTrial()
        {
            if (Application.Current == null || Application.Current.Windows.Count == 0)
            {
                return;
            }

            Application.Current.Windows[0].Page.DisplayAlertAsync("Demo!", "A complete App should navigate to a different page.", "OK");
        }

        private void OnContinue()
        {
            if (Application.Current == null || Application.Current.Windows.Count == 0)
            {
                return;
            }

            Application.Current.Windows[0].Page.DisplayAlertAsync("Demo!", $"Thanks for picking {SelectedPlan?.PlanName} plan :)", "OK");
        }

        private void OnGoToTermsOfService()
        {
            if (Application.Current == null || Application.Current.Windows.Count == 0)
            {
                return;
            }

            Application.Current.Windows[0].Page.DisplayAlertAsync("Demo!", "A complete  App should navigate to terms here.", "OK");
        }
    }
}