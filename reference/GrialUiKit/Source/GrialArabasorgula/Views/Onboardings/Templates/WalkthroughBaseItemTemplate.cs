/* [grial-metadata] id: Grial#WalkthroughBaseItemTemplate.cs version: 1.0.1 */
using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public abstract class WalkthroughBaseItemTemplate : ContentView
    {
        private bool _itemAppeared;

        public event EventHandler ItemAppearing;

        public event EventHandler ItemDisappearing;

        public event EventHandler ItemInitialized;

        /* TEXT */

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(
                nameof(Text),
                typeof(string),
                typeof(WalkthroughBaseItemTemplate),
                string.Empty);

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        /* HEADER */

        public static readonly BindableProperty HeaderProperty =
            BindableProperty.Create(
                nameof(Header),
                typeof(string),
                typeof(WalkthroughBaseItemTemplate),
                string.Empty);

        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        /* BUTTON */

        public static readonly BindableProperty ButtonTextProperty =
            BindableProperty.Create(
                nameof(ButtonText),
                typeof(string),
                typeof(WalkthroughBaseItemTemplate),
                string.Empty);

        public string ButtonText
        {
            get { return (string)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        public static readonly BindableProperty ButtonBackgroundColorProperty =
            BindableProperty.Create(
                nameof(ButtonBackgroundColor),
                typeof(Color),
                typeof(WalkthroughBaseItemTemplate),
                new Color());

        public Color ButtonBackgroundColor
        {
            get { return (Color)GetValue(ButtonBackgroundColorProperty); }
            set { SetValue(ButtonBackgroundColorProperty, value); }
        }

        /* ICON */

        public static readonly BindableProperty IconColorProperty =
            BindableProperty.Create(
                nameof(IconColor),
                typeof(Color),
                typeof(WalkthroughBaseItemTemplate),
                new Color());

        public Color IconColor
        {
            get { return (Color)GetValue(IconColorProperty); }
            set { SetValue(IconColorProperty, value); }
        }

        /* IMAGE */

        public static readonly BindableProperty StepBackgroundImageProperty =
            BindableProperty.Create(
                nameof(StepBackgroundImage),
                typeof(string),
                typeof(WalkthroughBaseItemTemplate),
                string.Empty);

        public string StepBackgroundImage
        {
            get { return (string)GetValue(StepBackgroundImageProperty); }
            set { SetValue(StepBackgroundImageProperty, value); }
        }

        public static readonly BindableProperty IconTextProperty =
            BindableProperty.Create(
                nameof(IconText),
                typeof(string),
                typeof(WalkthroughBaseItemTemplate),
                string.Empty);

        public string IconText
        {
            get { return (string)GetValue(IconTextProperty); }
            set { SetValue(IconTextProperty, value); }
        }

        public static readonly BindableProperty ActionButtonCommandProperty = BindableProperty.Create(
           nameof(ActionButtonCommand),
           typeof(ICommand),
           typeof(WalkthroughBaseItemTemplate));

        public ICommand ActionButtonCommand
        {
            get { return (ICommand)GetValue(ActionButtonCommandProperty); }
            set { SetValue(ActionButtonCommandProperty, value); }
        }

        public static readonly BindableProperty CloseCommandProperty = BindableProperty.Create(
           nameof(CloseCommand),
           typeof(ICommand),
           typeof(WalkthroughBaseItemTemplate));

        public ICommand CloseCommand
        {
            get { return (ICommand)GetValue(CloseCommandProperty); }
            set { SetValue(CloseCommandProperty, value); }
        }

        private bool _isCurrentItem = false;
        private Element _lastKnownParent;

        protected override void OnParentSet()
        {
            if (_lastKnownParent != null)
            {
                _lastKnownParent.PropertyChanged -= OnParentPropertyChanged;
            }

            base.OnParentSet();

            _lastKnownParent = Parent;
            if (Parent != null)
            {
                RiseItemInitialized();
                Parent.PropertyChanged += OnParentPropertyChanged;

                PositionUpdate();
            }
        }

        private void OnParentPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == CarouselBase.SelectedItemProperty.PropertyName)
            {
                PositionUpdate();
            }
        }

        private void PositionUpdate()
        {
            if (Parent is Carousel carousel && carousel.SelectedItem?.Equals(BindingContext) == true)
            {
                _isCurrentItem = true;
                RiseItemAppearing();
            }
            else
            {
                if (_isCurrentItem)
                {
                    RiseItemDisappearing();
                }

                _isCurrentItem = false;
            }
        }

        private void RiseItemInitialized()
        {
            ItemInitialized?.Invoke(this, EventArgs.Empty);
        }

        private void RiseItemAppearing()
        {
            if (!_itemAppeared)
            {
                _itemAppeared = true;
                ItemAppearing?.Invoke(this, EventArgs.Empty);
            }
        }

        private void RiseItemDisappearing()
        {
            _itemAppeared = false;
            ItemDisappearing?.Invoke(this, EventArgs.Empty);
        }
    }
}
