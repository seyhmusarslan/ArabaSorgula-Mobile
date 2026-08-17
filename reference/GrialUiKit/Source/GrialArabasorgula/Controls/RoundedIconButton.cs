/* [grial-metadata] id: Grial#RoundedIconButton.cs version: 1.0.4 */
using System;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class RoundedIconButton : RoundedIcon
    {
        public event EventHandler Clicked;

        public static readonly BindableProperty CommandProperty = BindableProperty.Create(
            nameof(Command),
            typeof(ICommand),
            typeof(RoundedIconButton),
            defaultValue: null);

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create(
            nameof(CommandParameter),
            typeof(object),
            typeof(RoundedIconButton),
            defaultValue: null);

        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public RoundedIconButton()
        {
            var gestureRecognizer = new TapGestureRecognizer();
            gestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, new Binding(nameof(Command), source: this));
            gestureRecognizer.SetBinding(TapGestureRecognizer.CommandParameterProperty, new Binding(nameof(CommandParameter), source: this));
            gestureRecognizer.Tapped += OnGestureRecognizerTapped;
            GestureRecognizers.Add(gestureRecognizer);
        }

        private void OnGestureRecognizerTapped(object sender, EventArgs e)
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
