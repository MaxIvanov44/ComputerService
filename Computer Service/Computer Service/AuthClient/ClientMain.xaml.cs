using Computer_Service.Resources;
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





        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ViewNowOrders vno = new ViewNowOrders();
            vno.Show();
            Close();
        }



        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            try
            {

                Clients cl = LGS.GetCurrentID();

                id.Content = cl.id_user;
                SaveCLID.CLID = cl.id_user;

                Model1 db = new Model1();

                var count = (from t in db.Orders
                             where t.client == SaveCLID.CLID
                             select t).Count();
                var inprocess = (from t in db.Orders
                                 where t.client == SaveCLID.CLID && t.order_status == 2
                                 select t).Count();
                var readyy = (from t in db.Orders
                                 where t.client == SaveCLID.CLID && t.order_status == 4
                                 select t).Count();
                var okk = (from t in db.Orders
                                 where t.client == SaveCLID.CLID && t.order_status == 5
                                 select t).Count();
                all.Content = count;
                now.Content = inprocess;
                ready.Content = readyy;
                ok.Content = okk;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
