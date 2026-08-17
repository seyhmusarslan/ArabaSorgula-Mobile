/* [grial-metadata] id: Grial#EmployeePerformanceDashboardPage.xaml version: 1.0.6 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class EmployeePerformanceDashboardPage : ContentPage
    {
        public EmployeePerformanceDashboardPage()
            : this(null)
        {
        }

        public EmployeePerformanceDashboardPage(FlowEmployeeData employee)
        {
            InitializeComponent();

            BindingContext = new EmployeePerformanceDashboardViewModel(
                employee, 
                Navigation);
        }
    }
}
