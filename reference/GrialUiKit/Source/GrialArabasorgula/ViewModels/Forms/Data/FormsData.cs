/* [grial-metadata] id: Grial#FormsData.cs version: 1.0.5 */
using UXDivers.Grial;
namespace arabasorgula
{
    public class PickerData
    {
        public string PickerTitle { get; set; }
        public List<string> PickerOptions { get; set; }
    }

    public class FormStep
    {
        public string Icon { get; init; }
        public string Title { get; init; }
        public string PrimaryActionText { get; init; }
        public FormStepViewModel Form { get; init; }
    }

    public abstract class FormStepViewModel : ObservableObject
    {
    }

    public class FormStepOneViewModel : FormStepViewModel
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _country;
        private string _address;
        private string _city;
        private string _zip;

        public string FirstName
        {
            get => _firstName;
            set => SetProperty(ref _firstName, value);
        }

        public string LastName
        {
            get => _lastName;
            set => SetProperty(ref _lastName, value);
        }

        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        public string Country
        {
            get => _country;
            set => SetProperty(ref _country, value);
        }

        public string Address
        {
            get => _address;
            set => SetProperty(ref _address, value);
        }

        public string City
        {
            get => _city;
            set => SetProperty(ref _city, value);
        }

        public string Zip
        {
            get => _zip;
            set => SetProperty(ref _zip, value);
        }
    }

    public class FormStepTwoViewModel : FormStepViewModel
    {
        private List<PickerData> _pickers;

        public FormStepTwoViewModel()
        {
            Pickers = [];
        }

        public List<PickerData> Pickers
        {
            get => _pickers;
            set => SetProperty(ref _pickers, value);
        }
    }

    public class FormStepThreeViewModel : FormStepViewModel
    {
        private List<PickerData> _pickers;

        public FormStepThreeViewModel()
        {
            Pickers = [];
        }

        public List<PickerData> Pickers
        {
            get => _pickers;
            set => SetProperty(ref _pickers, value);
        }
    }

}