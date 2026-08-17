/* [grial-metadata] id: Grial#AddContactPage.xaml version: 1.0.6 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class AddContactPage : ContentPage
    {
        public AddContactPage()
            : this(null)
        {
        }

        public AddContactPage(FlowContactData contact)
        {
            InitializeComponent();

            BindingContext = new AddContactViewModel(contact);
        }

        private async void OnSave(object sender, System.EventArgs e)
        {
            await DisplayAlertAsync(Resx.AppResources.StringSave, "Contact is not actually saved in this demo :)", Resx.AppResources.StringOK);
            await Navigation.PopAsync();
        }

        private async void OnImage(object sender, System.EventArgs e)
        {
            await DisplayAlertAsync("Image tapped", "Here you should choose the contact picture", Resx.AppResources.StringOK);
        }
    }
}
