/* [grial-metadata] id: Grial#WizardCountryListViewModel.cs version: 1.0.3 */
using System.Collections.ObjectModel;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class WizardCountryListViewModel : ObservableObject
    {
        private string _searchText;
        private IEnumerable<WizardCountryData> _countryList;

        public WizardCountryListViewModel(Action<WizardCountryData> select)
        {
            LoadData();

            SelectCommand = new Command<WizardCountryData>(select);
        }

        public ICommand SelectCommand { get; }

        public string SearchText
        {
            get => _searchText;
            set
            {
                if (SetProperty(ref _searchText, value))
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        CountryList = AllCountries;
                    }
                    else
                    {
                        CountryList = AllCountries.Where(x => x.Name.IndexOf(value, StringComparison.OrdinalIgnoreCase) >= 0).ToArray();
                    }
                }
            }
        }

        public Collection<WizardCountryData> AllCountries { get; } = new Collection<WizardCountryData>();

        public IEnumerable<WizardCountryData> CountryList 
        {
            get => _countryList;
            set => SetProperty(ref _countryList, value);
        }

        private void LoadData()
        {
            AllCountries.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "WizardFlow.json");

            CountryList = AllCountries.ToArray();
        }
    }
}