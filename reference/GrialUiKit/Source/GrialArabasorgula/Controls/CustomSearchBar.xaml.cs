/* [grial-metadata] id: Grial#CustomSearchBar.xaml version: 1.0.3 */
using System;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
	public partial class CustomSearchBar : ContentView
	{
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(
                nameof(Text),
                typeof(string),
                typeof(CustomSearchBar),
                defaultBindingMode: BindingMode.TwoWay);

        public static readonly BindableProperty PlaceholderProperty =
            BindableProperty.Create(
                nameof(Placeholder),
                typeof(string),
                typeof(CustomSearchBar));

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(
                nameof(TextColor),
                typeof(Color),
                typeof(CustomSearchBar));

        public static readonly BindableProperty PlaceholderColorProperty =
            BindableProperty.Create(
                nameof(PlaceholderColor),
                typeof(Color),
                typeof(CustomSearchBar));

        public static readonly BindableProperty ClearButtonColorProperty =
            BindableProperty.Create(
                nameof(ClearButtonColor),
                typeof(Color),
                typeof(CustomSearchBar));

        public static readonly BindableProperty SearchBackgroundColorProperty =
            BindableProperty.Create(
                nameof(SearchBackgroundColor),
                typeof(Color),
                typeof(CustomSearchBar),
                defaultValue: Colors.Transparent);

        public static readonly BindableProperty FontSizeProperty =
            BindableProperty.Create(
                nameof(FontSize),
                typeof(int),
                typeof(CustomSearchBar),
                defaultValue: 16);

        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create(
                nameof(CornerRadius),
                typeof(CornerRadius),
                typeof(CustomSearchBar));

        public static readonly BindableProperty HorizontalTextAlignmentProperty =
            BindableProperty.Create(
                nameof(HorizontalTextAlignment),
                typeof(TextAlignment),
                typeof(CustomSearchBar),
                defaultValue: TextAlignment.Start);

        public static readonly BindableProperty CompletedCommandProperty =
            BindableProperty.Create(
                nameof(CompletedCommand),
                typeof(ICommand),
                typeof(CustomSearchBar),
                defaultValue: null);

        public static readonly BindableProperty ClearCommandProperty =
            BindableProperty.Create(
                nameof(ClearCommand),
                typeof(ICommand),
                typeof(CustomSearchBar),
                defaultValue: null);

        public CustomSearchBar()
        {
            InitializeComponent();

            FocusTextCommand = new Command(() => searchEntry.Focus());
            ClearSearchCommand = new Command(ClearSearchBar);
        }

        public ICommand FocusTextCommand { get; }
        public ICommand ClearSearchCommand { get; }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public string Placeholder
        {
            get { return (string)GetValue(PlaceholderProperty); }
            set { SetValue(PlaceholderProperty, value); }
        }

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        public Color PlaceholderColor
        {
            get { return (Color)GetValue(PlaceholderColorProperty); }
            set { SetValue(PlaceholderColorProperty, value); }
        }

        public Color ClearButtonColor
        {
            get { return (Color)GetValue(ClearButtonColorProperty); }
            set { SetValue(ClearButtonColorProperty, value); }
        }

        public Color SearchBackgroundColor
        {
            get { return (Color)GetValue(SearchBackgroundColorProperty); }
            set { SetValue(SearchBackgroundColorProperty, value); }
        }

        public int FontSize
        {
            get { return (int)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public TextAlignment HorizontalTextAlignment
        {
            get { return (TextAlignment)GetValue(HorizontalTextAlignmentProperty); }
            set { SetValue(HorizontalTextAlignmentProperty, value); }
        }

        public ICommand CompletedCommand
        {
            get { return (ICommand)GetValue(CompletedCommandProperty); }
            set { SetValue(CompletedCommandProperty, value); }
        }

        public ICommand ClearCommand
        {
            get { return (ICommand)GetValue(ClearCommandProperty); }
            set { SetValue(ClearCommandProperty, value); }
        }

        private void ClearSearchBar()
        {
            searchEntry.Text = string.Empty;
            clearLabel.IsVisible = false;
            clearLabel.Unfocus();

            if (ClearCommand != null)
            {
                ClearCommand.Execute(null);
            }
        }

        private void OnTapped(object sender, EventArgs e)
        {
            ClearSearchBar();
        }

        private void OnCompleted(System.Object sender, EventArgs e)
        {
            if (CompletedCommand != null)
            {
                CompletedCommand.Execute(null);
            }
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(searchEntry.Text))
            {
                clearLabel.IsVisible = true;
            }
            else
            {
                clearLabel.IsVisible = false;
            }
        }

        private void OnUnfocused(object sender, FocusEventArgs e)
        {
            if (string.IsNullOrEmpty(searchEntry.Text))
            {
                clearLabel.IsVisible = false;
            }
        }

        private void OnFocused(object sender, FocusEventArgs e)
        {
            if (!string.IsNullOrEmpty(searchEntry.Text))
            {
                clearLabel.IsVisible = true;
            }
            else
            {
                clearLabel.IsVisible = false;
            }
        }
    }
}
