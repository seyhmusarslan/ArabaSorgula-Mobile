/* [grial-metadata] id: Grial#OrderConfirmationPage.xaml version: 1.0.1 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class OrderConfirmationPage : ContentPage
    {
        public OrderConfirmationPage()
            : this(null)
        {
        }

        public OrderConfirmationPage(FlowProductData product)
        {
            InitializeComponent();

            BindingContext = new OrderConfirmationViewModel(product);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            Triggers.Clear();
        }

        private async void OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CheckoutPage((OrderConfirmationViewModel)BindingContext));
        }

        private async void OnDelete(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
