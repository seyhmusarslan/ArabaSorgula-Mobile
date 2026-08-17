/* [grial-metadata] id: Grial#PricingPlanDViewModel.cs version: 1.1.6 */
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class PricingPlanDViewModel : ObservableObject
    {
        private double _rating;
        private string _reviews;
        private PlanItemDataD _selectedPlan;

        public PricingPlanDViewModel()
            : base(listenCultureChanges: true)
        {
            StartTrialCommand = new Command(OnStartTrial);
            ContinueCommand = new Command(OnContinue);
            RestorePurchaseCommand = new Command(OnRestorePurchase);
            GoToTermsAndCondsCommand = new Command(OnGoToTermsAndConds);

            LoadData();
        }

        public ICommand ContinueCommand { get; }
        public ICommand StartTrialCommand { get; }
        public ICommand RestorePurchaseCommand { get; }
        public ICommand GoToTermsAndCondsCommand { get; }

        public ObservableCollection<PlanItemDataD> Plans { get; } = new ObservableCollection<PlanItemDataD>();

        public PlanItemDataD SelectedPlan
        {
            get => _selectedPlan;
            set => SetProperty(ref _selectedPlan, value);
        }

        public double Rating
        {
            get { return _rating; }
            set { SetProperty(ref _rating, value); }
        }

        public string Reviews
        {
            get { return _reviews; }
            set { SetProperty(ref _reviews, value); }
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

        private void OnStartTrial()
        {
            if (Application.Current == null || Application.Current.Windows.Count == 0)
            {
                return;
            }
            
            Application.Current?.Windows[0]?.Page.DisplayAlertAsync("Demo!", "A complete App should navigate to a different page.", "OK");
        }

        private void OnContinue()
        {
            if (Application.Current == null || Application.Current.Windows.Count == 0)
            {
                return;
            }
            
            Application.Current?.Windows[0]?.Page.DisplayAlertAsync("Demo!", $"Thanks for picking {SelectedPlan?.PlanType} plan :)", "OK");
        }

        private void OnRestorePurchase()
        {
            if (Application.Current == null || Application.Current.Windows.Count == 0)
            {
                return;
            }
            
            Application.Current?.Windows[0]?.Page.DisplayAlertAsync("Demo!", "A complete App should navigate to a different page.", "OK");
        }

        private void OnGoToTermsAndConds()
        {
            if (Application.Current == null || Application.Current.Windows.Count == 0)
            {
                return;
            }
            
            Application.Current?.Windows[0]?.Page.DisplayAlertAsync("Demo!", "A complete App should navigate to a different page.", "OK");
        }
    }
}