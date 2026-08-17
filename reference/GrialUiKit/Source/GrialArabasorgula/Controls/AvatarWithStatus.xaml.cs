/* [grial-metadata] id: Grial#AvatarWithStatus.xaml version: 1.0.1 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class AvatarWithStatus : ContentView
    {
        public static readonly BindableProperty IsCircularProperty = BindableProperty.Create(
           nameof(IsCircular),
           typeof(bool),
           typeof(AvatarWithStatus),
           propertyChanged: (b, o, n) => ((AvatarWithStatus)b).UpdateIsCircularImage());

        public bool IsCircular
        {
            get { return (bool)GetValue(IsCircularProperty); }
            set { SetValue(IsCircularProperty, value); }
        }

        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(
           nameof(BorderColor),
           typeof(Color),
           typeof(AvatarWithStatus));

        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly BindableProperty BorderSizeProperty = BindableProperty.Create(
           nameof(BorderSize),
           typeof(double),
           typeof(AvatarWithStatus),
           propertyChanged: (b, o, n) => ((AvatarWithStatus)b).UpdateSize());

        public double BorderSize
        {
            get { return (double)GetValue(BorderSizeProperty); }
            set { SetValue(BorderSizeProperty, value); }
        }

        public static readonly BindableProperty SourceProperty = BindableProperty.Create(
           nameof(Source),
           typeof(string),
           typeof(AvatarWithStatus));

        public string Source
        {
            get { return (string)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(
           nameof(CornerRadius),
           typeof(double),
           typeof(AvatarWithStatus),
           propertyChanged: (b, o, n) => ((AvatarWithStatus)b).UpdateCornerRadius());

        public double CornerRadius
        {
            get { return (double)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly BindableProperty SizeProperty = BindableProperty.Create(
           nameof(Size),
           typeof(double),
           typeof(AvatarWithStatus),
           50.0,
           propertyChanged: (b, o, n) => ((AvatarWithStatus)b).UpdateSize());

        public double Size
        {
            get { return (double)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }

        public static readonly BindableProperty AspectProperty = BindableProperty.Create(
           nameof(Aspect),
           typeof(Aspect),
           typeof(AvatarWithStatus),
           Aspect.Fill);

        public Aspect Aspect
        {
            get { return (Aspect)GetValue(AspectProperty); }
            set { SetValue(AspectProperty, value); }
        }

        /* ========= STATUS INDICATOR PROPERTIES ============== */

        public static readonly BindableProperty StatusIndicatorPositionProperty = BindableProperty.Create(
           nameof(StatusIndicatorPosition),
           typeof(StatusIndicatorPosition),
           typeof(AvatarWithStatus),
           StatusIndicatorPosition.TopRight,
           propertyChanged: (b, o, n) => ((AvatarWithStatus)b).UpdateStatusIndicatorPosition());

        public StatusIndicatorPosition StatusIndicatorPosition
        {
            get { return (StatusIndicatorPosition)GetValue(StatusIndicatorPositionProperty); }
            set { SetValue(StatusIndicatorPositionProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorShiftProperty = BindableProperty.Create(
           nameof(StatusIndicatorShift),
           typeof(double),
           typeof(AvatarWithStatus),
           propertyChanged: (b, o, n) => ((AvatarWithStatus)b).UpdateStatusIndicatorPosition());

        public double StatusIndicatorShift
        {
            get { return (double)GetValue(StatusIndicatorShiftProperty); }
            set { SetValue(StatusIndicatorShiftProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorAutoHideProperty = BindableProperty.Create(
           nameof(StatusIndicatorAutoHide),
           typeof(bool),
           typeof(AvatarWithStatus),
           Badge.AutoHideProperty.DefaultValue);

        public bool StatusIndicatorAutoHide
        {
            get { return (bool)GetValue(StatusIndicatorAutoHideProperty); }
            set { SetValue(StatusIndicatorAutoHideProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorSizeProperty = BindableProperty.Create(
           nameof(StatusIndicatorSize),
           typeof(double),
           typeof(AvatarWithStatus),
           Badge.SizeProperty.DefaultValue);

        public double StatusIndicatorSize
        {
            get { return (double)GetValue(StatusIndicatorSizeProperty); }
            set { SetValue(StatusIndicatorSizeProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorBorderSizeProperty = BindableProperty.Create(
           nameof(StatusIndicatorBorderSize),
           typeof(double),
           typeof(AvatarWithStatus),
           Badge.BorderSizeProperty.DefaultValue);

        public double StatusIndicatorBorderSize
        {
            get { return (double)GetValue(StatusIndicatorBorderSizeProperty); }
            set { SetValue(StatusIndicatorBorderSizeProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorColorProperty = BindableProperty.Create(
           nameof(StatusIndicatorColor),
           typeof(Color),
           typeof(AvatarWithStatus),
           Badge.BackgroundColorProperty.DefaultValue);

        public Color StatusIndicatorColor
        {
            get { return (Color)GetValue(StatusIndicatorColorProperty); }
            set { SetValue(StatusIndicatorColorProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorBorderColorProperty = BindableProperty.Create(
           nameof(StatusIndicatorBorderColor),
           typeof(Color),
           typeof(AvatarWithStatus),
           Badge.BorderColorProperty.DefaultValue);

        public Color StatusIndicatorBorderColor
        {
            get { return (Color)GetValue(StatusIndicatorBorderColorProperty); }
            set { SetValue(StatusIndicatorBorderColorProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorTextProperty = BindableProperty.Create(
           nameof(StatusIndicatorText),
           typeof(string),
           typeof(AvatarWithStatus),
           Badge.TextProperty.DefaultValue);

        public string StatusIndicatorText
        {
            get { return (string)GetValue(StatusIndicatorTextProperty); }
            set { SetValue(StatusIndicatorTextProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorTextColorProperty = BindableProperty.Create(
           nameof(StatusIndicatorTextColor),
           typeof(Color),
           typeof(AvatarWithStatus),
           Badge.TextColorProperty.DefaultValue);

        public Color StatusIndicatorTextColor
        {
            get { return (Color)GetValue(StatusIndicatorTextColorProperty); }
            set { SetValue(StatusIndicatorTextColorProperty, value); }
        }

        public static readonly BindableProperty StatusIndicatorFontSizeProperty = BindableProperty.Create(
           nameof(StatusIndicatorFontSize),
           typeof(double),
           typeof(AvatarWithStatus),
           Badge.FontSizeProperty.DefaultValue);

        public double StatusIndicatorFontSize
        {
            get { return (double)GetValue(StatusIndicatorFontSizeProperty); }
            set { SetValue(StatusIndicatorFontSizeProperty, value); }
        }

        public static readonly BindableProperty IsStatusIndicatorIconProperty = BindableProperty.Create(
           nameof(IsStatusIndicatorIcon),
           typeof(bool),
           typeof(AvatarWithStatus),
           propertyChanged: (b, o, n) => ((AvatarWithStatus)b).UpdateBadgeType());

        public bool IsStatusIndicatorIcon
        {
            get { return (bool)GetValue(IsStatusIndicatorIconProperty); }
            set { SetValue(IsStatusIndicatorIconProperty, value); }
        }

        public static readonly BindableProperty DropShadowProperty =
            BindableProperty.Create(
                nameof(DropShadow),
                typeof(DropShadowType),
                typeof(AvatarWithStatus),
                defaultValue: DropShadowType.None);

        public DropShadowType DropShadow
        {
            get { return (DropShadowType)GetValue(DropShadowProperty); }
            set { SetValue(DropShadowProperty, value); }
        }

        /* ====================================================== */

        private double _lastCornerRadious = 0;

        public AvatarWithStatus()
        {
            InitializeComponent();

            UpdateBadgeType();

            UpdateSize();

            UpdateStatusIndicatorPosition();
        }

        private void UpdateIsCircularImage()
        {
            if (IsCircular)
            {
                _lastCornerRadious = CornerRadius;
                CornerRadius = Size / 2;
            }
            else
            {
                CornerRadius = _lastCornerRadious;
                _lastCornerRadious = 0;
            }
        }

        private void UpdateSize()
        {
            HeightRequest = Size + (BorderSize * 2);
            WidthRequest = Size + (BorderSize * 2);

            UpdateCornerRadius();
        }

        private void UpdateBorder()
        {
            if (Size > 0)
            {
                if (BorderSize == 0)
                {
                    borderBoxView.IsVisible = false;
                }
                else
                {
                    var cornerRadius = CornerRadius + BorderSize;
                    var heightRequest = Size + (BorderSize * 2);
                    var widthRequest = Size + (BorderSize * 2);

                    borderBoxView.IsVisible = true;

                    if (UXDivers.Grial.Effects.GetCornerRadius(borderBoxView) != cornerRadius || borderBoxView.HeightRequest != heightRequest || borderBoxView.WidthRequest != widthRequest)
                    {
                        borderBoxView.HeightRequest = heightRequest;
                        borderBoxView.WidthRequest = widthRequest;
                        UXDivers.Grial.Effects.SetCornerRadius(borderBoxView, cornerRadius);
                    }
                }
            }
        }

        private void UpdateCornerRadius()
        {
            if (IsCircular && CornerRadius != Size / 2)
            {
                CornerRadius = Size / 2;
            }

            UpdateBorder();
        }

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

#if ANDROID
            // Like android clips the content of the contentview, we need to increase its dimension to include the badge position
            Padding = new Thickness(StatusIndicatorShift);
            HeightRequest = HeightRequest + Padding.VerticalThickness;
            WidthRequest = WidthRequest + Padding.HorizontalThickness;
#endif
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
    }
}
