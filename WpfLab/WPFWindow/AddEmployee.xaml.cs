using Lab.Model;
using Laba.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFWindow
{
    /// <summary>
    /// Логика взаимодействия для AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        EmployeeService _employeeService;
        public AddEmployee()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(TitleTb.Text) || !String.IsNullOrEmpty(CompanyTb.Text) || !String.IsNullOrEmpty(PriceTb.Text))
                {
                    _employeeService.Create(new Employee { Name = TitleTb.Text, Address = CompanyTb.Text, City = PriceTb.Text });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
