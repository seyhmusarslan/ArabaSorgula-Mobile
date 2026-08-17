/* [grial-metadata] id: Grial#RoundedIconWithBadge.xaml version: 1.0.1 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class RoundedIconWithBadge : RoundedIcon
    {
        /* ========= STATUS INDICATOR PROPERTIES ============== */

        public static readonly BindableProperty StatusIndicatorPositionProperty = BindableProperty.Create(
           nameof(StatusIndicatorPosition),
           typeof(StatusIndicatorPosition),
           typeof(RoundedIconWithBadge),
           StatusIndicatorPosition.TopRight,
           propertyChanged: (b, o, n) => ((RoundedIconWithBadge)b).UpdateStatusIndicatorPosition());

        public StatusIndicatorPosition StatusIndicatorPosition
        {
            get { return (StatusIndicatorPosition)GetValue(StatusIndicatorPositionProperty); }
            set { SetValue(StatusIndicatorPositionProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorShiftProperty = BindableProperty.Create(
           nameof(StatusIndicatorShift),
           typeof(double),
           typeof(RoundedIconWithBadge),
           propertyChanged: (b, o, n) => ((RoundedIconWithBadge)b).UpdateStatusIndicatorPosition());

        public double StatusIndicatorShift
        {
            get { return (double)GetValue(StatusIndicatorShiftProperty); }
            set { SetValue(StatusIndicatorShiftProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorAutoHideProperty = BindableProperty.Create(
           nameof(StatusIndicatorAutoHide),
           typeof(bool),
           typeof(RoundedIconWithBadge),
           Badge.AutoHideProperty.DefaultValue);

        public bool StatusIndicatorAutoHide
        {
            get { return (bool)GetValue(StatusIndicatorAutoHideProperty); }
            set { SetValue(StatusIndicatorAutoHideProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorSizeProperty = BindableProperty.Create(
           nameof(StatusIndicatorSize),
           typeof(double),
           typeof(RoundedIconWithBadge),
           Badge.SizeProperty.DefaultValue);

        public double StatusIndicatorSize
        {
            get { return (double)GetValue(StatusIndicatorSizeProperty); }
            set { SetValue(StatusIndicatorSizeProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorBorderSizeProperty = BindableProperty.Create(
           nameof(StatusIndicatorBorderSize),
           typeof(double),
           typeof(RoundedIconWithBadge),
           Badge.BorderSizeProperty.DefaultValue);

        public double StatusIndicatorBorderSize
        {
            get { return (double)GetValue(StatusIndicatorBorderSizeProperty); }
            set { SetValue(StatusIndicatorBorderSizeProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorColorProperty = BindableProperty.Create(
           nameof(StatusIndicatorColor),
           typeof(Color),
           typeof(RoundedIconWithBadge),
           Badge.BackgroundColorProperty.DefaultValue);

        public Color StatusIndicatorColor
        {
            get { return (Color)GetValue(StatusIndicatorColorProperty); }
            set { SetValue(StatusIndicatorColorProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorBorderColorProperty = BindableProperty.Create(
           nameof(StatusIndicatorBorderColor),
           typeof(Color),
           typeof(RoundedIconWithBadge),
           Badge.BorderColorProperty.DefaultValue);

        public Color StatusIndicatorBorderColor
        {
            get { return (Color)GetValue(StatusIndicatorBorderColorProperty); }
            set { SetValue(StatusIndicatorBorderColorProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorTextProperty = BindableProperty.Create(
           nameof(StatusIndicatorText),
           typeof(string),
           typeof(RoundedIconWithBadge),
           Badge.TextProperty.DefaultValue);

        public string StatusIndicatorText
        {
            get { return (string)GetValue(StatusIndicatorTextProperty); }
            set { SetValue(StatusIndicatorTextProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorTextColorProperty = BindableProperty.Create(
           nameof(StatusIndicatorTextColor),
           typeof(Color),
           typeof(RoundedIconWithBadge),
           Badge.TextColorProperty.DefaultValue);

        public Color StatusIndicatorTextColor
        {
            get { return (Color)GetValue(StatusIndicatorTextColorProperty); }
            set { SetValue(StatusIndicatorTextColorProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorFontSizeProperty = BindableProperty.Create(
           nameof(StatusIndicatorFontSize),
           typeof(double),
           typeof(RoundedIconWithBadge),
           Badge.FontSizeProperty.DefaultValue);

        public double StatusIndicatorFontSize
        {
            get { return (double)GetValue(StatusIndicatorFontSizeProperty); }
            set { SetValue(StatusIndicatorFontSizeProperty, value); }
        }

        public static readonly BindableProperty IsStatusIndicatorIconProperty = BindableProperty.Create(
           nameof(IsStatusIndicatorIcon),
           typeof(bool),
           typeof(RoundedIcon),
           propertyChanged: (b, o, n) => ((RoundedIconWithBadge)b).UpdateBadgeType());

        public bool IsStatusIndicatorIcon
        {
            get { return (bool)GetValue(IsStatusIndicatorIconProperty); }
            set { SetValue(IsStatusIndicatorIconProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorIconAttributeProperty = BindableProperty.Create(
            nameof(StatusIndicatorIconAttribute),
            typeof(IconAttribute),
            typeof(RoundedIcon),
           propertyChanged: (b, o, n) => ((RoundedIconWithBadge)b).IconAttributeChanged());

        public IconAttribute StatusIndicatorIconAttribute
        {
            get { return (IconAttribute)GetValue(StatusIndicatorIconAttributeProperty); }
            set { SetValue(StatusIndicatorIconAttributeProperty, value); }
        }

        /* ====================================================== */

        public RoundedIconWithBadge()
            : base(initialize: false)
        {
            InitializeComponent();

            UpdateStatusIndicatorPosition();
        }

        protected override View GetBackground() => background;

        protected override View GetRoot() => root;

        private void UpdateStatusIndicatorPosition()
        {
            if (indicator == null)
            {
                return;
            }

            var indicatorMargin = default(Thickness);

            switch (StatusIndicatorPosition)
            {
                case StatusIndicatorPosition.TopLeft:
                    indicator.HorizontalOptions = LayoutOptions.Start;
                    indicator.VerticalOptions = LayoutOptions.Start;

                    indicatorMargin.Top -= StatusIndicatorShift;
                    indicatorMargin.Left -= StatusIndicatorShift;

                    break;

                case StatusIndicatorPosition.TopRight:
                    indicator.HorizontalOptions = LayoutOptions.End;
                    indicator.VerticalOptions = LayoutOptions.Start;

                    indicatorMargin.Top -= StatusIndicatorShift;
                    indicatorMargin.Right -= StatusIndicatorShift;

                    break;

                case StatusIndicatorPosition.BottomLeft:
                    indicator.HorizontalOptions = LayoutOptions.Start;
                    indicator.VerticalOptions = LayoutOptions.End;

                    indicatorMargin.Bottom -= StatusIndicatorShift;
                    indicatorMargin.Left -= StatusIndicatorShift;

                    break;

                case StatusIndicatorPosition.BottomRight:
                    indicator.HorizontalOptions = LayoutOptions.End;
                    indicator.VerticalOptions = LayoutOptions.End;

                    indicatorMargin.Bottom -= StatusIndicatorShift;
                    indicatorMargin.Right -= StatusIndicatorShift;

                    break;
            }

            indicator.Margin = indicatorMargin;
        }

        private void UpdateBadgeType()
        {
            if (IsStatusIndicatorIcon)
            {
                indicator.SetDynamicResource(Badge.FontFamilyProperty, "IconsFontFamily");
            }
            else
            {
                indicator.SetDynamicResource(Badge.FontFamilyProperty, "AppFontFamily");
            }
        }

        private void IconAttributeChanged()
        {
            if (StatusIndicatorIconAttribute == IconAttribute.Line)
            {
                indicator.SetDynamicResource(Badge.FontFamilyProperty, "IconsFontFamily");
            }
            else
            {
                indicator.SetDynamicResource(Badge.FontFamilyProperty, "GrialIconsFill");
            }
        }
    }
}
