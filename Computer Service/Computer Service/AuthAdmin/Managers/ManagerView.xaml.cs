using Database.EntityModels;
using Logic.LogicModels;
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
    public partial class ManagerView : MetroWindow
    {
        public ManagerView()
        {
            InitializeComponent();
        }

        private DataTable dtord = new DataTable();

        private void viewdgr_Loaded(object sender, RoutedEventArgs e)
        {
            dtord = LogicManagers.GetAllManagers();
            viewdgr.ItemsSource = dtord.DefaultView;
        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            LogicManagers.CurrentManager(Convert.ToInt32(dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString()
                           ));
            UpdateManager upd = new UpdateManager();
            upd.Show();
            Close();
        }

        private void btncreate_Click(object sender, RoutedEventArgs e)
        {
            AddManager am = new AddManager();
            am.Show();
            Close();
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            var del = Convert.ToInt32(dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString());
            int delete = Convert.ToInt32(del);
            btndelete.Content = del.ToString();
            if (MessageBox.Show("Точно хотите удалить менеджера?", "ВНИМАНИЕ", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                MessageBox.Show("Операция отменена");
            }
            else
            {
                Model1 db = new Model1();
                Managers cl = db.Managers
                    .Where(d => d.id_manager == delete)
                    .FirstOrDefault();
                db.Managers.Remove(cl);
                db.SaveChanges();
                MessageBox.Show("Удаление менеджера " + "\"" + cl.first_name + " " + cl.last_name + "  с ID = " + cl.id_manager + " \"" + " произведено!");
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