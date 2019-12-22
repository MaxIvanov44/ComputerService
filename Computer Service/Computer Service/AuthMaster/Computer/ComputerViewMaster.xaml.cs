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
    public partial class ComputerViewMaster : MetroWindow
    {
        public ComputerViewMaster()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            Logic.LogicComputers.CurrentPC(Convert.ToInt32(dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString()
              ));
            UpdateComputerMaster upd = new UpdateComputerMaster();
            upd.Show();
            Close();
        }

        private void btncreate_Click(object sender, RoutedEventArgs e)
        {
            AddComputerMaster ac = new AddComputerMaster();
            ac.Show();
            Close();
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            var del = Convert.ToInt32(dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString());
            int delete = Convert.ToInt32(del);
            btndelete.Content = del.ToString();
            if (MessageBox.Show("Точно хотите удалить технику?", "ВНИМАНИЕ", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                MessageBox.Show("Операция отменена");
            }
            else
            {
                Model1 db = new Model1();

                Computers cl = db.Computers
                    .Where(d => d.id_comp == delete)
                    .FirstOrDefault();
                db.Computers.Remove(cl);
                db.SaveChanges();
                MessageBox.Show("Удаление техники " + "\"" + cl.name + " " + cl.brand + " " + cl.model + " с ID = " + cl.id_comp + " \"" + " произведено!");
            }
        }

        private DataTable dtord = new DataTable();

        private void viewdgr_Loaded(object sender, RoutedEventArgs e)
        {
            dtord = Logic.LogicComputers.GetAllPC();
            viewdgr.ItemsSource = dtord.DefaultView;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MasterMain mm = new MasterMain();
            mm.Show();
            Close();
        }
    }
}