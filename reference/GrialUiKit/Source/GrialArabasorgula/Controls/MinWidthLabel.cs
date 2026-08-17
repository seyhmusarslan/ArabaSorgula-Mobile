/* [grial-metadata] id: Grial#MinWidthLabel.cs version: 1.1.6 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public class MinWidthLabel : Label
    {
        public static readonly BindableProperty MinWidthProperty =
            BindableProperty.Create(
                nameof(MinWidth),
                typeof(double),
                typeof(MinWidthLabel),
                defaultValue: 0d,
                propertyChanged: (s, o, n) => ((MinWidthLabel)s).InvalidateMeasure());

        public double MinWidth
        {
            get { return (double)GetValue(MinWidthProperty); }
            set { SetValue(MinWidthProperty, value); }
        }

        public static readonly BindableProperty WidthMarginProperty =
            BindableProperty.Create(
                nameof(WidthMargin),
                typeof(double),
                typeof(MinWidthLabel),
                defaultValue: 0d,
                propertyChanged: (s, o, n) => ((MinWidthLabel)s).InvalidateMeasure());

        public double WidthMargin
        {
            get { return (double)GetValue(WidthMarginProperty); }
            set { SetValue(WidthMarginProperty, value); }
        }

        // protected override Size MeasureOverride(double widthConstraint, double heightConstraint)
        // {
        //     var result = base.MeasureOverride(widthConstraint, heightConstraint);

        //     result = new Size(Math.Max(MinWidth, result.Width + WidthMargin), result.Height);

        //     return result;
        // }
    }
}