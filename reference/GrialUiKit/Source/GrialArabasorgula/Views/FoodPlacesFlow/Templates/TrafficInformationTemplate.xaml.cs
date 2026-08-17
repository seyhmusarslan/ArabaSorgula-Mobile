/* [grial-metadata] id: Grial#TrafficInformationTemplate.xaml version: 1.0.1 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class TrafficInformationTemplate : ContentView
    {
        public static readonly BindableProperty IconTextProperty = BindableProperty.Create(
            nameof(IconText),
            typeof(string),
            typeof(TrafficInformationTemplate));

        public string IconText
        {
            get { return (string)GetValue(IconTextProperty); }
            set { SetValue(IconTextProperty, value); }
        }

        public static readonly BindableProperty TitleProperty = BindableProperty.Create(
            nameof(Title),
            typeof(string),
            typeof(TrafficInformationTemplate));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly BindableProperty DescriptionProperty = BindableProperty.Create(
            nameof(Description),
            typeof(string),
            typeof(TrafficInformationTemplate));

        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        public TrafficInformationTemplate()
        {
            InitializeComponent();
        }
    }
}
