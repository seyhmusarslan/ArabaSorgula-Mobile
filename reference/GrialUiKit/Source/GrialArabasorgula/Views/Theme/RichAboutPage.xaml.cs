/* [grial-metadata] id: Grial#RichAboutPage.xaml version: 1.1.6 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class RichAboutPage : ContentPage
    {
        public RichAboutPage()
        {
            InitializeComponent();

            BindingContext = new RichAboutViewModel();
        }
    }
}
