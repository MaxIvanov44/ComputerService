using Database.EntityModels;
using Logic;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public partial class UpdateOrder : MetroWindow
    {
        public UpdateOrder()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
                Orders orders = Logic.LogicOrders.GetCurrentOrder();
                idtxt.Text = orders.id_order.ToString();
                client.ItemsSource = LogicClient.GetNameClient();
                master.ItemsSource = LogicMaster.GetNameMaster();
                pc.ItemsSource = LogicComputers.GetMark();
                status.ItemsSource = LogicStatus.GetStatus();
                DateTime? date1 = orders.date_of_acceptance;
                DateTime? date2 = orders.date_of_return;
                accept.SelectedDate = orders.date_of_acceptance;
                @return.SelectedDate = orders.date_of_return;
                price.Text = orders.repair_price.Value.ToString();
                description.Text = orders.description;
                //price.Text = orders.id_order.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Model1 db = new Model1();
           int a = Convert.ToInt32(idtxt.Text);
            var orderr = db.Orders
                .Where(c => c.id_order == a)
                .FirstOrDefault();

            // Внести изменения
            orderr.order_status = Convert.ToInt32(LogicStatus.GetIdStatus(status.Text));
            orderr.client = Convert.ToInt32(LogicClient.GetIdClient(client.Text));
            orderr.master = Convert.ToInt32(LogicMaster.GetIdMaster(master.Text));
            orderr.computer = Convert.ToInt32(LogicComputers.GetIdMark(pc.Text));


            orderr.date_of_acceptance = accept.DisplayDate;
            orderr.date_of_return = @return.DisplayDate;
            orderr.repair_price = Convert.ToInt32(price.Text);
            orderr.description = description.Text;

            // Сохранить изменения
         db.SaveChanges();

            //Orders order = new Orders
            //{

            //    order_status = Convert.ToInt32(LogicStatus.GetIdStatus(status.Text)),
            //    client = Convert.ToInt32(LogicClient.GetIdClient(client.Text)),
            //    master = Convert.ToInt32(LogicMaster.GetIdMaster(master.Text)),
            //    computer = Convert.ToInt32(LogicComputers.GetIdMark(pc.Text)),


            //    date_of_acceptance = accept.DisplayDate,
            //    date_of_return = @return.DisplayDate,
            //    repair_price = Convert.ToInt32(price.Text),
            //    description = description.Text
            //};
            //db.Orders.Add(order);
            //db.SaveChanges();
            MessageBox.Show("Заказ изменён!");
            Close();
        }
    }
}
