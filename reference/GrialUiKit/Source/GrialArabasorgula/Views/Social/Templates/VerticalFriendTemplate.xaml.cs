/* [grial-metadata] id: Grial#VerticalFriendTemplate.xaml version: 1.0.1 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class VerticalFriendTemplate : ContentView
    {
        public static readonly BindableProperty ImageProperty = BindableProperty.Create(
           nameof(Image),
           typeof(string),
           typeof(VerticalFriendTemplate));

        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(
           nameof(Text),
           typeof(string),
           typeof(VerticalFriendTemplate));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public VerticalFriendTemplate()
        {
            InitializeComponent();
        }
    }
}
