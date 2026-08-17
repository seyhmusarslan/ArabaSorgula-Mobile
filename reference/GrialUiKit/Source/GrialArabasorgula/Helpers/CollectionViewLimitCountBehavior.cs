/* [grial-metadata] id: Grial#CollectionViewLimitCountBehavior.cs version: 1.0.1 */
using System;
using System.Collections;
using UXDivers.Grial;

namespace arabasorgula
{
    public class CollectionViewLimitCountBehavior : Behavior<CollectionView>
    {
        public static readonly BindableProperty ItemHeightProperty =
            BindableProperty.CreateAttached(
                "ItemHeight",
                typeof(double),
                typeof(CollectionViewLimitCountBehavior),
                defaultValue: -1d,
                propertyChanged: OnItemHeightChanged);

        public static void SetItemHeight(BindableObject view, double value)
        {
            view.SetValue(ItemHeightProperty, value);
        }

        public static double GetItemHeight(BindableObject view)
        {
            return (double)view.GetValue(ItemHeightProperty);
        }

        public static readonly BindableProperty CountLimitProperty =
            BindableProperty.Create(
                nameof(CountLimit),
                typeof(int),
                typeof(CollectionViewLimitCountBehavior),
                defaultValue: -1,
                propertyChanged: OnCountLimitChanged);

        public int CountLimit
        {
            get { return (int)GetValue(CountLimitProperty); }
            set { SetValue(CountLimitProperty, value); }
        }

        private CollectionView _collectionView;
        private IEnumerable _originalSource;

        protected override void OnAttachedTo(CollectionView bindable)
        {
            base.OnAttachedTo(bindable);

            _collectionView = bindable;

            if (_collectionView != null)
            {
                _collectionView.PropertyChanged += OnCollectionViewPropertyChanged;
                _originalSource = _collectionView.ItemsSource;

                Update();
            }
        }

        protected override void OnDetachingFrom(CollectionView bindable)
        {
            if (_collectionView != null)
            {
                _collectionView.PropertyChanged -= OnCollectionViewPropertyChanged;
                _collectionView = null;
            }

            base.OnDetachingFrom(bindable);
        }

        private static void OnCountLimitChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((CollectionViewLimitCountBehavior)bindable).Update();
        }

        private static void OnItemHeightChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if ((((CollectionView)bindable)?.Behaviors?.Count ?? 0) == 0)
            {
                return;
            }

            if (((CollectionView)bindable).Behaviors[0] is CollectionViewLimitCountBehavior behavior)
            {
                behavior.Update();
            }
        }

        private void OnCollectionViewPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (_originalSource == null && e.PropertyName == CollectionView.ItemsSourceProperty.PropertyName)
            {
                _originalSource = _collectionView.ItemsSource;
                Update();
            }
        }

        private void Update()
        {
            if (_collectionView != null && _originalSource != null)
            {
                int count;
                if (CountLimit < 0)
                {
                    _collectionView.ItemsSource = _originalSource;
                    count = _originalSource.Cast<object>().Count();
                }
                else
                {
                    var source = _originalSource.Cast<object>().Take(CountLimit).ToList();
                    count = source.Count;
                    _collectionView.ItemsSource = source;
                }

                UpdateHeight(count);
            }
        }

        private void UpdateHeight(int count)
        {
            if (count == 0)
            {
                _collectionView.HeightRequest = -1;
            }
            else
            {
                _collectionView.HeightRequest = GetItemHeight(_collectionView) * count;
            }
        }
	}
}

