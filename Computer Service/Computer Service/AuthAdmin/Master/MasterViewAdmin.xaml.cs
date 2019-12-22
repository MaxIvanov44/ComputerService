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
    public partial class MasterViewAdmin : MetroWindow
    {
        public MasterViewAdmin()
        {
            InitializeComponent();
        }

        private DataTable dtord = new DataTable();

        private void viewdgr_Loaded(object sender, RoutedEventArgs e)
        {
            dtord = Logic.LogicMaster.GetAllMasters();
            viewdgr.ItemsSource = dtord.DefaultView;
        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            Logic.LogicMaster.CurrentMaster(Convert.ToInt32(dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString()
                           ));
            UpdateMaster upd = new UpdateMaster();
            upd.Show();
            Close();
        }

        private void btncreate_Click(object sender, RoutedEventArgs e)
        {
            AddMaster am = new AddMaster();
            am.Show();
            Close();
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            var del = Convert.ToInt32(dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString());
            int delete = Convert.ToInt32(del);
            btndelete.Content = del.ToString();
            if (MessageBox.Show("Точно хотите удалить мастера?", "ВНИМАНИЕ", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                MessageBox.Show("Операция отменена");
            }
            else
            {
                Model1 db = new Model1();
                Masters cl = db.Masters
                    .Where(d => d.id_master == delete)
                    .FirstOrDefault();
                db.Masters.Remove(cl);
                db.SaveChanges();
                MessageBox.Show("Удаление мастера " + "\"" + cl.first_name + " " + cl.last_name + "  с ID = " + cl.id_master + " \"" + " произведено!");
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