using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace PDC03_MOD04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity3 : ContentPage
    {

        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public ObservableCollection<Employee> Employees { get { return employees; } }
        public activity3()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Bin", position = "Top", Image = "rngbin.jpeg" });
            employees.Add(new Employee { DisplayName = "Wei", position = "Jungle", Image = "rngwei.jpeg" });
            employees.Add(new Employee { DisplayName = "Xiaohu", position = "Mid", Image = "rngxiaohu.jpeg" });
            employees.Add(new Employee { DisplayName = "GALA", position = "Bottom", Image = "rnggala.jpeg" });
            employees.Add(new Employee { DisplayName = "Ming", position = "Support", Image = "rngming.jpeg" });
        }
    }
}