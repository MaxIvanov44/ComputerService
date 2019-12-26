using Database.EntityModels;
using Logic;
using MahApps.Metro.Controls;
using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class ClientView : MetroWindow
    {
        public ClientView()
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
                if (a == null || b == null) MessageBox.Show("Выберите клиента!");
                else
                {
                    string cc = (d + " " + a + " " + b).ToString();
                    LogicOrders.c = cc;

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
            dtord = Logic.LogicClient.GetAllClients();
            viewdgr.ItemsSource = dtord.DefaultView;
        }

        private void btnselect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var d = dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString();
                var a = dtord.Rows[viewdgr.SelectedIndex].ItemArray[1].ToString();
                var b = dtord.Rows[viewdgr.SelectedIndex].ItemArray[2].ToString();
                if (a == null || b == null) MessageBox.Show("Выберите клиента!");
                else
                {
                    string cc = (d + " " + a + " " + b).ToString();
                    LogicOrders.c = cc;

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

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            Logic.LogicClient.CurrentClient(Convert.ToInt32(dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString()
                   ));
            UpdateClient upd = new UpdateClient();
            upd.Show();
            Close();
        }

        private void btncreate_Click(object sender, RoutedEventArgs e)
        {
            AddClient ac = new AddClient();
            ac.Show();
            Close();
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            var del = Convert.ToInt32(dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString());
            int delete = Convert.ToInt32(del);
            btndelete.Content = del.ToString();
            if (MessageBox.Show("Точно хотите удалить клиента?", "ВНИМАНИЕ", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                MessageBox.Show("Операция отменена");
            }
            else
            {
                Model1 db = new Model1();
                Clients cl = db.Clients
                    .Where(d => d.id_user == delete)
                    .FirstOrDefault();
                db.Clients.Remove(cl);
                db.SaveChanges();
                MessageBox.Show("Удаление пользователя " + "\"" + cl.first_name + " " + cl.last_name + "  с ID = " + cl.id_user + " \"" + " произведено!");
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            ManagerMain mm = new ManagerMain();
            mm.Show();
            Close();
        }
    }
}