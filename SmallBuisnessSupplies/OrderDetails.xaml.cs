using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace SmallBuisnessSupplies
{
    /// <summary>
    /// Логика взаимодействия для OrderDetails.xaml
    /// </summary>
    public partial class OrderDetails : Window
    {
        SmallBusinessSuppliesEntities context = new SmallBusinessSuppliesEntities();
        CollectionViewSource custViewSource;
        public OrderDetails()
        {
            InitializeComponent();
            custViewSource = (CollectionViewSource)(FindResource("vW_OrdersViewSource"));
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context.VW_ClientOrder.Load();
            custViewSource.Source = context.VW_ClientOrder.Local;
        }
    }
}
