﻿using Database.EntityModels;
using Logic;
using MahApps.Metro.Controls;
using System;
using System.Linq;
using System.Windows;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class UpdateOrderMaster : MetroWindow
    {
        public UpdateOrderMaster()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Model1 db = new Model1();
            Clients cl = new Clients();
            Orders orders = Logic.LogicOrders.GetCurrentOrder();
            var a = Convert.ToInt32(idtxt.Text);
            var data = from Order in db.Orders
                       join Status in db.StatusMaster on Order.order_status equals Status.id_status
                       join Client in db.Clients on Order.client equals Client.id_user
                       join Master in db.Masters on Order.master equals Master.id_master
                       join Computers in db.Computers on Order.computer equals Computers.id_comp
                       where Order.id_order == a
                       select new
                       {
                           Id = Order.id_order,
                           Status = Status.status,
                           Client = Client.id_user + " " + Client.first_name + " " + Client.last_name,
                           PC = Computers.id_comp + " " + Computers.name + " " + Computers.brand + " " + Computers.model,
                           Master = Master.id_master + " " + Master.first_name + " " + Master.last_name + " " + Master.middle_name,
                           DateAccept = Order.date_of_acceptance,
                           DateRepair = Order.date_of_return,
                           Price = Order.repair_price,
                           Descpription = Order.description
                       };

            idtxt.Text = orders.id_order.ToString();
            client.Text = data.FirstOrDefault().Client;
            master.Text = data.FirstOrDefault().Master;
            master.Text = data.FirstOrDefault().PC;
            status.ItemsSource = LogicStatus.GetStatusMaster();
            status.Text = data.FirstOrDefault().Status;
            DateTime? date1 = orders.date_of_acceptance;
            DateTime? date2 = orders.date_of_return;
            accept.SelectedDate = orders.date_of_acceptance;
            @return.SelectedDate = orders.date_of_return;
            price.Text = orders.repair_price.Value.ToString();
            description.Text = orders.description;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Model1 db = new Model1();
                int a = Convert.ToInt32(idtxt.Text);
                var orderr = db.Orders
                    .Where(c => c.id_order == a)
                    .FirstOrDefault();

                orderr.order_status = Convert.ToInt32(LogicStatus.GetIdStatus(status.Text));
                orderr.client = Convert.ToInt32(LogicClient.GetIdClient(client.Text));
                orderr.master = Convert.ToInt32(LogicMaster.GetIdMaster(master.Text));
                orderr.computer = Convert.ToInt32(LogicComputers.GetIdMark(pc.Text));

                orderr.date_of_acceptance = accept.DisplayDate;
                orderr.date_of_return = @return.DisplayDate;
                orderr.repair_price = Convert.ToInt32(price.Text);
                orderr.description = description.Text;

                db.SaveChanges();

                MessageBox.Show("Заказ изменён!");
                ViewOrderMaster vo = new ViewOrderMaster();
                vo.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewOrderMaster vo = new ViewOrderMaster();
            vo.Show();
            Close();
        }
    }
}