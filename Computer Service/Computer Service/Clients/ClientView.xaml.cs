using Database.EntityModels;
using MahApps.Metro.Controls;
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

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class ClientView: MetroWindow
    {
        public ClientView()
        {
            InitializeComponent();
            refreshdata();
        }
        void refreshdata()
        {
            Model1 db = new Model1();
            var data = from list in db.Clients select list;
                       //select new
                       //{
                       //    Услуга = list.service,
                       //    Ценаот = list.price_from,
                       //    Ценадо = list.price_up
                       //};

            viewdgr.ItemsSource = data.ToList();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnselect_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btncreate_Click(object sender, RoutedEventArgs e)
        {
            AddClient ac = new AddClient();
            ac.ShowDialog();
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
