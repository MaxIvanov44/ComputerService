using Database.EntityModels;
using MahApps.Metro.Controls;
using System.Diagnostics;
using System.Linq;
using System.Windows;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class ManagerMain : MetroWindow
    {
        public ManagerMain()
        {
            InitializeComponent();
            Model1 db = new Model1();

            var inprocesss = (from t in db.Orders
                              where t.order_status == 2
                              select t).Count();
            var okk = (from t in db.Orders
                       where t.order_status == 4
                       select t).Count();

            ok.Content = okk;
            inprocess.Content = inprocesss;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MasterView mv = new MasterView();
            mv.Show();
            Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            ClientView cv = new ClientView();
            cv.Show();
            Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/MaxIvanov44");
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            AddOrder ao = new AddOrder();
            ao.Show();
            Close();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            ViewOrder vo = new ViewOrder();
            vo.Show();
            Close();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}