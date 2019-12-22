using MahApps.Metro.Controls;
using System.Diagnostics;
using System.Windows;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class AdminMain : MetroWindow
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ManagerView mv = new ManagerView();
            mv.Show();
            Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            ClientViewAdmin cv = new ClientViewAdmin();
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
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            ViewOrderAdmin vo = new ViewOrderAdmin();
            vo.Show();
            Close();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            MasterViewAdmin mv = new MasterViewAdmin();
            mv.Show();
            Close();
        }
    }
}