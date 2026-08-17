/* [grial-metadata] id: Grial#VideoListPreviewPage.xaml version: 1.0.3 */
using System;
using System.Collections.Generic;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class VideoListPreviewPage : ContentPage
    {
        public static readonly BindableProperty DoPlayProperty = BindableProperty.CreateAttached(
            "DoPlay",
            typeof(bool),
            typeof(VideoListPreviewPage),
            false,
            propertyChanged: (s, o, n) =>
            {
                var video = (VideoPlayer)s;
                var play = (bool)n;
                (video.BindingContext as MovieData).IsPlaying = play;
                if (play)
                {
                    video.Play();
                }
                else
                {
                    video.Pause();
                }

                video.HideSkin();
            });

        public static bool GetDoPlay(BindableObject view)
        {
            return (bool)view.GetValue(DoPlayProperty);
        }

        public static void SetDoPlay(BindableObject view, bool value)
        {
            view.SetValue(DoPlayProperty, value);
        }

        private LazyExpander _lastExpander;

        public VideoListPreviewPage()
        {
            InitializeComponent();
            BindingContext = new VideoListPreviewViewModel();
        }

        private void ExpanderTapped(object sender, ExpandedChangedEventArgs e)
        {
            if (_lastExpander != null && _lastExpander != sender as LazyExpander)
            {
                _lastExpander.IsExpanded = false;
            }

            if ((sender as LazyExpander).IsExpanded)
            {
                _lastExpander = sender as LazyExpander;
            }
        }
    }
}
