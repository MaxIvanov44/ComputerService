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
    public partial class MasterMain : MetroWindow
    {
        public MasterMain()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MasterView mv = new MasterView();
            mv.ShowDialog();
            
        }

       

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            ClientView cv = new ClientView();
            cv.ShowDialog();
        }



        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {


            Process.Start("https://github.com/MaxIvanov44");


        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            AddOrder ao = new AddOrder();
            ao.ShowDialog();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
          
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            ViewOrder vo = new ViewOrder();
            vo.Show();
            Close();
        }
    }
}
