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
using System.Data.Entity;

namespace SmallBuisnessSupplies
{
    /// <summary>
    /// Логика взаимодействия для EmployeesAndOrders.xaml
    /// </summary>
    public partial class EmployeesAndOrders : Window
    {
        SmallBusinessSuppliesEntities context = new SmallBusinessSuppliesEntities();
        CollectionViewSource custViewSource;
        public EmployeesAndOrders()
        {
            InitializeComponent();
            custViewSource = (CollectionViewSource)(FindResource("vW_EmployeeOrderViewSource"));
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context.VW_EmployeeOrder.Load();
            custViewSource.Source = context.VW_EmployeeOrder.Local;
        }
    }
}
