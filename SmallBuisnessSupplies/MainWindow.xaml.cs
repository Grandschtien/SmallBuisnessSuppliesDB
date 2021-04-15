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

        private void Clients_Click(object sender, RoutedEventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
              
        }

        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
        }

        private void Details_Click(object sender, RoutedEventArgs e)
        {
            Details details = new Details();
            details.Show();
        }

        private void Employee_Click(object sender, RoutedEventArgs e)
        {
            Emloyees emp = new Emloyees();
            emp.Show();
        }

        private void Catalog_Click(object sender, RoutedEventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
        }

        private void Stocks_Click(object sender, RoutedEventArgs e)
        {
            Stocks stocks = new Stocks();
            stocks.Show();
        }

        private void Providers_Click(object sender, RoutedEventArgs e)
        {
            Providers prv = new Providers();
            prv.Show();
        }
    }
}
