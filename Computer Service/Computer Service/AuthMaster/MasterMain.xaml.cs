using Database.EntityModels;
using Logic;
using MahApps.Metro.Controls;
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
            Masters mas = LGS.GetMasterID();
            SaveMASID.MASID = mas.id_master;

            InitializeComponent();
            Model1 db = new Model1();
            var count = (from t in db.Orders
                         where t.client == SaveMASID.MASID && t.order_status == 1
                         select t).Count();
            var inprocess = (from t in db.Orders
                             where t.order_status == 2 && t.client == SaveMASID.MASID
                             select t).Count();
            var readyy = (from t in db.Orders
                          where t.order_status == 4 && t.client == SaveMASID.MASID
                          select t).Count();
            all.Content = count;
            now.Content = inprocess;
            ready.Content = readyy;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            Close();
            mw.Show();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            ViewOrderMaster vo = new ViewOrderMaster();
            vo.Show();
            Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ComputerViewMaster cv = new ComputerViewMaster();
            cv.Show();
            Close();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}