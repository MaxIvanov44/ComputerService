using Computer_Service.Resources;
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
    public partial class MasterMain : MetroWindow
    {
        public MasterMain()
        {
            InitializeComponent();
            Model1 db = new Model1();
            var count = (from t in db.Orders
                         select t).Count();
            var inprocess = (from t in db.Orders
                             where t.order_status == 2
                             select t).Count();
            all.Content = count;
            now.Content = inprocess;
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
            Close();
            mw.Show();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            ViewOrder vo = new ViewOrder();
            vo.Show();
            Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Model1 db = new Model1();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}