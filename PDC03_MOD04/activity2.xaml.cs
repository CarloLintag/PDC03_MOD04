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
    public partial class activity2 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public activity2()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Zeus", position = "Top", Image = "t1zeus.jpg" });
            employees.Add(new Employee { DisplayName = "Oner", position = "Jungle", Image = "t1oner.jpeg" });
            employees.Add(new Employee { DisplayName = "Faker", position = "Mid", Image = "t1faker.jpg" });
            employees.Add(new Employee { DisplayName = "Gumayusi", position = "Bot", Image = "t1guma.jpeg" });
            employees.Add(new Employee { DisplayName = "Keria", position = "Support", Image = "t1keria.jpeg" });
        }
    }
}