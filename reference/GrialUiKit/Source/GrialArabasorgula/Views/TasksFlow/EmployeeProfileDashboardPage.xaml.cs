/* [grial-metadata] id: Grial#EmployeeProfileDashboardPage.xaml version: 1.1.6 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class EmployeeProfileDashboardPage : ContentPage
    {
        public EmployeeProfileDashboardPage()
            : this(null)
        {
        }

        public EmployeeProfileDashboardPage(FlowEmployeeData employee)
        {
            InitializeComponent();

            BindingContext = new EmployeeProfileDashboardViewModel(
                employee,
                Navigation);
        }
    }
}
