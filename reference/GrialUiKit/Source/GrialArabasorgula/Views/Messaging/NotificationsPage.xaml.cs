/* [grial-metadata] id: Grial#NotificationsPage.xaml version: 1.0.1 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class NotificationsPage : ContentPage
    {
        public NotificationsPage()
        {
            InitializeComponent();

            BindingContext = new NotificationsViewModel();
        }
    }
}
