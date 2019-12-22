using Database.EntityModels;
using MahApps.Metro.Controls;
using System;
using System.Data;
using System.Linq;
using System.Windows;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class ClientViewAdmin : MetroWindow
    {
        public ClientViewAdmin()
        {
            InitializeComponent();
        }

        private DataTable dtord = new DataTable();

        private void viewdgr_Loaded(object sender, RoutedEventArgs e)
        {
            dtord = Logic.LogicClient.GetAllClients();
            viewdgr.ItemsSource = dtord.DefaultView;
        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            Logic.LogicClient.CurrentClient(Convert.ToInt32(dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString()
                   ));
            UpdateClientAdmin upd = new UpdateClientAdmin();
            upd.Show();
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
            AdminMain mm = new AdminMain();
            mm.Show();
            Close();
        }
    }
}