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
            //var data = from Order in db.Orders
            //           join Status in db.Status on Order.order_status equals Status.id_status
            //           join Client in db.Clients on Order.client equals Client.id_user
            //           join Master in db.Masters on Order.master equals Master.id_master
            //           join Computers in db.Computers on Order.computer equals Computers.id_comp
            //           select new
            //           {
            //               Id = Order.id_order,
            //               Status = Status.status1,
            //               Client = Client.first_name + " " + Client.last_name + " ",
            //               PC = Computers.name + " " + Computers.brand + " " + Computers.model,
            //               Master = Master.first_name + " "  + Master.last_name + " "  + Master.middle_name,
            //               DateAccept = Order.date_of_acceptance,
            //               DateRepair = Order.date_of_return,
            //               Price = Order.repair_price,
            //               Descpription = Order.description
            //           };
            //viewdgr.ItemsSource = data.ToList();
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
            MasterMain mm = new MasterMain();
            mm.Show();
            Close();
        }
    }
}