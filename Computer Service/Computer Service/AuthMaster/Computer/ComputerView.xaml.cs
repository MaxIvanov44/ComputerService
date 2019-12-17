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
    public partial class ComputerView : MetroWindow
    {
        public ComputerView()
        {
            InitializeComponent();
        }

        private void btnselect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var pcid = dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString();
                var a = dtord.Rows[viewdgr.SelectedIndex].ItemArray[1].ToString();
                var b = dtord.Rows[viewdgr.SelectedIndex].ItemArray[2].ToString();
                var d = dtord.Rows[viewdgr.SelectedIndex].ItemArray[3].ToString();
                if (a == null || b == null) MessageBox.Show("Выберите ПК!");
                else
                {
                    string cc = (pcid + " " + a + " " + b + " " + d).ToString();
                    LogicOrders.pc = cc;

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
            Logic.LogicComputers.CurrentPC(Convert.ToInt32(dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString()
              ));
            UpdateComputer upd = new UpdateComputer();
            upd.Show();
            Close();
        }

        private void btncreate_Click(object sender, RoutedEventArgs e)
        {
            AddComputer ac = new AddComputer();
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

        private void viewdgr_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var pcid = dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString();
                var a = dtord.Rows[viewdgr.SelectedIndex].ItemArray[1].ToString();
                var b = dtord.Rows[viewdgr.SelectedIndex].ItemArray[2].ToString();
                var d = dtord.Rows[viewdgr.SelectedIndex].ItemArray[3].ToString();
                if (a == null || b == null) MessageBox.Show("Выберите ПК!");
                else
                {
                    string cc = (pcid + " " + a + " " + b + " " + d).ToString();
                    LogicOrders.pc = cc;

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