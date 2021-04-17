using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmallBuisnessSupplies
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //const string connectionString = @"Data Source=.\;Initial Catalog=SmallBusinessSupplies;Integrated Security=True";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClientsOrdersButton(object sender, RoutedEventArgs e)
        {
            ClientsOrdersTable COT = new ClientsOrdersTable();
            COT.Show();
        }

        private void EmployeeButton(object sender, RoutedEventArgs e)
        {
            EmployeesAndOrders emp = new EmployeesAndOrders();
            emp.Show();
        }

        private void OrdersButton(object sender, RoutedEventArgs e)
        {
            OrderDetails orders = new OrderDetails();
            orders.Show();
        }

        private void CatalogButton(object sender, RoutedEventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
        }
    }
}
