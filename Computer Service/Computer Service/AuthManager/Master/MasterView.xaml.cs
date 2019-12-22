using Logic;
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
    public partial class MasterView : MetroWindow
    {
        public MasterView()
        {
            InitializeComponent();
        }

        private DataTable dtord = new DataTable();

        private void viewdgr_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var d = dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString();
                var a = dtord.Rows[viewdgr.SelectedIndex].ItemArray[1].ToString();
                var b = dtord.Rows[viewdgr.SelectedIndex].ItemArray[2].ToString();
                if (a == null || b == null) MessageBox.Show("Выберите мастера!");
                else
                {
                    string cc = (d + " " + a + " " + b).ToString();
                    LogicOrders.m = cc;

                    AddOrder ao = new AddOrder();
                    ao.Show();

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewdgr_Loaded(object sender, RoutedEventArgs e)
        {
            dtord = Logic.LogicMaster.GetAllMasters();
            viewdgr.ItemsSource = dtord.DefaultView;
        }

        private void btnselect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var d = dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString();
                var a = dtord.Rows[viewdgr.SelectedIndex].ItemArray[1].ToString();
                var b = dtord.Rows[viewdgr.SelectedIndex].ItemArray[2].ToString();
                if (a == null || b == null) MessageBox.Show("Выберите мастера!");
                else
                {
                    string cc = (d + " " + a + " " + b).ToString();
                    LogicOrders.m = cc;

                    AddOrder ao = new AddOrder();
                    ao.Show();

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MasterMain mm = new MasterMain();
            mm.Show();
            Close();
        }
    }
}