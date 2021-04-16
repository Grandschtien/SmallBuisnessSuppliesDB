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
using System.Data.Entity;
using System.Windows.Shapes;
using System.IO;

namespace SmallBuisnessSupplies
{
    /// <summary>
    /// Логика взаимодействия для ClientsOrdersTable.xaml
    /// </summary>
    public partial class ClientsOrdersTable : Window
    {
        SmallBusinessSuppliesEntities context = new SmallBusinessSuppliesEntities();
        CollectionViewSource custViewSource;
        public ClientsOrdersTable()
        {
            InitializeComponent();
            custViewSource = (CollectionViewSource)(FindResource("vW_ClientOrderViewSource"));
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context.VW_ClientOrder.Load();
            custViewSource.Source = context.VW_ClientOrder.Local;
        }
    }
}
