/* [grial-metadata] id: Grial#RatingLabel.xaml version: 1.0.1 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class RatingLabel : ContentView
    {
        public static readonly BindableProperty ValueProperty =
            BindableProperty.Create(
                nameof(Value),
                typeof(double),
                typeof(RatingLabel),
                defaultValue: 0d);

        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public RatingLabel()
        {
            InitializeComponent();
        }
    }
}
