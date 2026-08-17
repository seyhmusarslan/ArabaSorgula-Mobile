/* [grial-metadata] id: Grial#ShippingDetailViewModel.cs version: 1.0.6 */
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class ShippingDetailViewModel : ObservableObject
    {
        private int _state;
        private ObservableCollection<ShipmentData> _items;

        public ShippingDetailViewModel()
            : base(listenCultureChanges: true)
        {
            LoadData();
        }

        public ObservableCollection<ShipmentData> InTransit { get; } = new ObservableCollection<ShipmentData>();
        public ObservableCollection<ShipmentData> Closed { get; } = new ObservableCollection<ShipmentData>();
        public ObservableCollection<ShipmentData> All { get; } = new ObservableCollection<ShipmentData>();

        public int State
        {
            get => _state;
            set
            {
                if (!SetProperty(ref _state, value))
                {
                    return;
                }

                switch (_state)
                {
                    case 0:
                        Items = All;
                        break;
                    case 1:
                        Items = InTransit;
                        break;
                    case 2:
                        Items = Closed;
                        break;
                    default:
                        break;
                }
            }
        }

        public ObservableCollection<ShipmentData> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            InTransit.Clear();
            Closed.Clear();
            All.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "DataViz.json");

            Items = All;
        }
    }
}
