/* [grial-metadata] id: Grial#ObservableObject.cs version: 1.1.5 */
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using UXDivers.Grial;

namespace arabasorgula
{
    /// <summary>
    /// Simple implementation of INotifyPropertyChanged.
    /// </summary>
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly CultureChangeNotifier _notifier;

        public ObservableObject(bool listenCultureChanges = false)
        {
            if (listenCultureChanges)
            {
                // Listen culture changes so they can be handled 
                // by derived viewmodels if needed
                _notifier = new CultureChangeNotifier();
                _notifier.CultureChanged += CultureChanged;
            }
        }

        protected void NotifyAllPropertiesChanged()
        {
            NotifyPropertyChanged(null);
        }

        protected bool SetProperty<T>(
            ref T backingStore,
            T value,
            [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
            {
                return false;
            }

            backingStore = value;
            NotifyPropertyChanged(propertyName);

            return true;
        }

        protected bool SetProperty<T>(
           ref T backingStore,
           T value,
           [CallerMemberName] string propertyName = "",
           params string[] dependencies)
        {
            if (!SetProperty(ref backingStore, value, propertyName))
            {
                return false;
            }

            if (dependencies != null && dependencies.Length > 0)
            {
                for (var i = 0; i < dependencies.Length; i++)
                {
                    NotifyPropertyChanged(dependencies[i]);
                }
            }

            return true;
        }

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnCultureChanged(CultureInfo culture)
        {
        }

        private void CultureChanged(object sender, CultureChangeEventArgs args)
        {
            OnCultureChanged(args.NewCulture);
        }
    }
}