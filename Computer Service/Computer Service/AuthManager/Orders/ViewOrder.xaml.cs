using Database.EntityModels;
using MahApps.Metro.Controls;
using System;
using System.Data;
using System.Windows;
using System.Windows.Input;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class ViewOrder : MetroWindow
    {
        public ViewOrder()
        {
            InitializeComponent();
            Model1 db = new Model1();
        }

        private void viewdgr_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Logic.LogicOrders.CurrentOrder(Convert.ToInt32(dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString()
                ));
            UpdateOrder upd = new UpdateOrder();
            upd.Show();
            Close();
        }

        private DataTable dtord = new DataTable();

        private void viewdgr_Loaded(object sender, RoutedEventArgs e)
        {
            dtord = Logic.LogicOrders.GetAllOrders();
            viewdgr.ItemsSource = dtord.DefaultView;
        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            Logic.LogicOrders.CurrentOrder(Convert.ToInt32(dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString()
               ));
            UpdateOrder upd = new UpdateOrder();
            upd.Show();
            Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            ManagerMain mm = new ManagerMain();
            mm.Show();
            Close();
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
        }
    }
}