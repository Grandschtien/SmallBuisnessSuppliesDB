﻿using System;
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
using System.Windows.Shapes;

namespace SmallBuisnessSupplies
{
    /// <summary>
    /// Логика взаимодействия для Stocks.xaml
    /// </summary>
    public partial class Stocks : Window
    {
        const string connectionString = @"Data Source=.\;Initial Catalog=SmallBusinessSupplies;Integrated Security=True";

        public Stocks()
        {
            InitializeComponent();
            DeportamentsView();
        }
        private void DeportamentsView()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string cmd = "SELECT * FROM Stocks"; // Из какой таблицы нужен вывод 
            SqlCommand createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Stocks"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            StocksGrid.ItemsSource = dt.DefaultView; // Сам вывод 
            connection.Close();

        }
    }
}
