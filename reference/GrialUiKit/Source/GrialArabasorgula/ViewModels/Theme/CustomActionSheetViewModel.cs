/* [grial-metadata] id: Grial#CustomActionSheetViewModel.cs version: 1.0.1 */
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class CustomActionSheetViewModel : ObservableObject
    {
        private string _title;

        public CustomActionSheetViewModel()
            : base(listenCultureChanges: true)
        {
            LoadData();
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ObservableCollection<ActionData> Actions { get; } = new ObservableCollection<ActionData>();

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            Actions.Clear();

            JsonHelper.Instance.LoadViewModel(this, pageName: "CustomActionSheet.xaml", source: "Theme.json");
        }
    }
}
