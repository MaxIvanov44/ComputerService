using Database.EntityModels;
using MahApps.Metro.Controls;
using System.Data;
using System.Windows;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class ViewOrderAdmin : MetroWindow
    {
        public ViewOrderAdmin()
        {
            InitializeComponent();
            Model1 db = new Model1();
        }

        private DataTable dtord = new DataTable();

        private void viewdgr_Loaded(object sender, RoutedEventArgs e)
        {
            dtord = Logic.LogicOrders.GetAllOrders();
            viewdgr.ItemsSource = dtord.DefaultView;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            AdminMain mm = new AdminMain();
            mm.Show();
            Close();
        }
    }
}