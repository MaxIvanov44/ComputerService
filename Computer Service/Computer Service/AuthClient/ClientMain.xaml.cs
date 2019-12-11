using Database.EntityModels;
using Logic;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public partial class ClientMain : MetroWindow
    {
        public ClientMain()
        {
            InitializeComponent();
        }


        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/MaxIvanov44/ComputerService");
        }



        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Model1 db = new Model1();

               Clients cl = LGS.GetCurrentID();
                var a = cl.id_user;
                var data = from r in db.Orders.Where(idc => idc.client == a) select r;
                view.ItemsSource = data.ToList();
                id.Content = cl.id_user;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
