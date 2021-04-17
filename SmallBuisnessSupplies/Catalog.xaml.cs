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
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Window
    {
        SmallBusinessSuppliesEntities context = new SmallBusinessSuppliesEntities();
        CollectionViewSource custViewSource;
        public Catalog()
        {
            InitializeComponent();
            custViewSource = (CollectionViewSource)(FindResource("vW_ProductsCatalogViewSource"));
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context.VW_ClientOrder.Load();
            custViewSource.Source = context.VW_ClientOrder.Local;
        }
    }
}
