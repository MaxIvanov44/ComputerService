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
    public partial class ClientView: MetroWindow
    {
        public ClientView()
        {
            InitializeComponent();
            //refreshdata();
        }
        void refreshdata()
        {
            Model1 db = new Model1();
            var data = from list in db.Clients select list;
                       //select new
                       //{
                       //    Услуга = list.service,
                       //    Ценаот = list.price_from,
                       //    Ценадо = list.price_up
                       //};

            viewdgr.ItemsSource = data.ToList();
        }
        DataTable dtord = new DataTable();
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
                MessageBox.Show("Удаление пользователя " + "\"" + cl.first_name + " " + cl.last_name + "  с ID = " + cl.id_user + " \"" +" произведено!" );
            }



            //SampleContext context = new SampleContext();
            //Order order = context.Orders
            //    .Where(o => o.OrderId == 8)
            //    .FirstOrDefault();

            //context.Orders.Remove(order);
            //context.SaveChanges();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MasterMain mm = new MasterMain();
            mm.Show();
            Close();
        }
    }
}
