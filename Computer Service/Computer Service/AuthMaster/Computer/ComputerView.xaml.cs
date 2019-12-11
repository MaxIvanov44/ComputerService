using Database.EntityModels;
using Logic;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Data;
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
    public partial class ComputerView: MetroWindow
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
            //UpdatePC upd = new UpdatePC();
            //upd.Show();
            Close();
        }

        private void btncreate_Click(object sender, RoutedEventArgs e)
        {
            AddComputer ac = new AddComputer();
            ac.ShowDialog();
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        DataTable dtord = new DataTable();
        private void viewdgr_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Logic.LogicComputers.CurrentPC(Convert.ToInt32(dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString()
                ));
            //UpdatePC upd = new UpdatePC();
            //upd.Show();
            Close();

        }
        private void viewdgr_Loaded(object sender, RoutedEventArgs e)
        {
            dtord = Logic.LogicComputers.GetAllPC();
            viewdgr.ItemsSource = dtord.DefaultView;

        }
    }
}
