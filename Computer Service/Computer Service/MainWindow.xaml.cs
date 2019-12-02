using Database;
using Database.EntityModels;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            refreshdata();
           
        }

       
       void refreshdata()
        {
            Model1 db = new Model1();
           var data = from list in db.PriceList
                                         select new
                                         {
                                             Услуга = list.service,
                                             Ценаот = list.price_from,
                                             Ценадо = list.price_up
                                         };

            pricelistdgr.ItemsSource = data.ToList();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if  (Auth.authoriz(username.Text, password.Password) == true)
            {
                MasterMain ms = new MasterMain();
                this.Close();
                ms.Show();
            }
            else
            {
                MessageBox.Show("YAY2");
            }


        }
        bool y = true;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (y == true)
            {
                this.Background = new SolidColorBrush(Colors.White);
                color.Background = new SolidColorBrush(Color.FromRgb(64, 73, 82));
                login.Foreground = new SolidColorBrush(Colors.Black);
                pas.Foreground = new SolidColorBrush(Colors.Black);
                y = false;
            }
            else
            {
                this.Background = new SolidColorBrush(Color.FromRgb(64, 73, 82));
                color.Background = new SolidColorBrush(Colors.White);
                login.Foreground = new SolidColorBrush(Colors.White);
                pas.Foreground = new SolidColorBrush(Colors.White);
                y = true;
            }
          
        }
    }
}
