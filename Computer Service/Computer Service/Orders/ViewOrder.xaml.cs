using Database.EntityModels;
using Logic.LogicModels;
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
    public partial class ViewOrder: MetroWindow
    {
        public ViewOrder()
        {
            InitializeComponent();
            refreshdata();
        }
        void refreshdata()
        {


            Model1 db = new Model1();

            var data = from Order in db.Orders
                       join Status in db.Status on Order.order_status equals Status.id_status
                       join Client in db.Clients on Order.client equals Client.id_user
                       join Master in db.Masters on Order.master equals Master.id_master
                       join Computers in db.Computers on Order.computer equals Computers.id_comp
                       select new
                       {
                           Id = Order.id_order,
                           Status = Status.status1,
                           Client = Client.first_name + Client.last_name,
                           PC = Computers.mark + Computers.model,
                           Master = Master.first_name + Master.last_name + Master.middle_name,
                           DateAccept = Order.date_of_acceptance,
                           DateRepair = Order.date_of_return,
                           Price = Order.repair_price,
                           Descpription = Order.description

                       };


            viewdgr.ItemsSource = data.ToList();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnselect_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btncreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {

        }
        DataTable dtOrder = new DataTable();

        private void viewdgr_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            LogicOrders.CurrentTransport(Convert.ToInt32(dtOrder.Rows[viewdgr.SelectedIndex].ItemArray[4].ToString()));

            AddOrder ao = new AddOrder();
            ao.ShowDialog();
        }
    }
}
