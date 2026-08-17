/* [grial-metadata] id: Grial#FAQsPage.xaml version: 1.1.6 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class FAQsPage : ContentPage
    {
        public FAQsPage()
        {
            InitializeComponent();
            BindingContext = new FAQsViewModel();
        }
    }
}
