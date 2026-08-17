/* [grial-metadata] id: Grial#ContactSimpleDetailViewModel.cs version: 1.1.6 */
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class ContactSimpleDetailViewModel : ObservableObject
    {
        private string _avatar;

        public ContactSimpleDetailViewModel()
            : base(listenCultureChanges: true)
        {
            LoadData();
        }

        public string Avatar
        {
            get { return _avatar; }
            set { SetProperty(ref _avatar, value); }
        }

        public ObservableCollection<ValueData> Values { get; } = new ObservableCollection<ValueData>();
        public ICommand ActionCommand => new Command<string>(async (txt) => 
        {
            if (Application.Current == null || Application.Current.Windows.Count == 0)
            {
                return;
            }

            await Application.Current?.Windows[0]?.Page.DisplayAlertAsync("Button Tapped", $"{txt} Tapped", "Ok");
        });

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            Values.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Social.json");
        }

        public class ValueData
        {
            public string Label { get; set; }
            public string Value { get; set; }
        }
    }
}
