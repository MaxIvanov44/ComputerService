using Database.EntityModels;
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
    public partial class UpdateOrder : MetroWindow
    {
        public UpdateOrder()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Model1 db = new Model1();
            Clients cl = new Clients();

            Orders orders = Logic.LogicOrders.GetCurrentOrder();

            idtxt.Text = orders.id_order.ToString();
            var a = Convert.ToInt32(idtxt.Text);
            //var r = db.Clients.Find(a);
            //var rr = r;
            //var data = from r in db.Clients
            //         .Where(t => t.id_user == a)
            //         .Select(t => t.id_user + " " + t.first_name + " " + t.last_name)
            //         .FirstOrDefault()
            //client.Text = Convert.ToString(data);
            //master.Text = LogicMaster.GetNameMaster();
            //pc.Text = LogicComputers.GetMark();
            status.ItemsSource = LogicStatus.GetStatus();
            DateTime? date1 = orders.date_of_acceptance;
            DateTime? date2 = orders.date_of_return;
            accept.SelectedDate = orders.date_of_acceptance;
            @return.SelectedDate = orders.date_of_return;
            price.Text = orders.repair_price.Value.ToString();
            description.Text = orders.description;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewOrder vo = new ViewOrder();
            vo.Show();
            Close();
        }
    }
}