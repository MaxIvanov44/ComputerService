using Database.EntityModels;
using Logic;
using MahApps.Metro.Controls;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class UpdateOrder : MetroWindow
    {
        int globalid;
        object countcompl = 0;
        public UpdateOrder()
        {
            InitializeComponent();

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {



            Model1 db = new Model1();
            Orders orders = Logic.LogicOrders.GetCurrentOrder();
            idtxt.Text = orders.id_order.ToString();

            var a = Convert.ToInt32(idtxt.Text);

            globalid = a;

            string connectionString = @"data source=MAX-PC\SQLEXPRESS;initial catalog=ComputerService;integrated security=True;";
            string sqlExpression2 = "SELECT COUNT(*) FROM dbo.Details WHERE [Order] = " + a;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression2, connection);
                var ident_current = command.ExecuteScalar();
                countcompl = ident_current;
                LogicOrders.count = Convert.ToInt32(countcompl);
                connection.Close();
            }

            peka.Text = "Количество: " +  countcompl;

            var data = from Order in db.Orders
                       join Statusman in db.Status on Order.order_status equals Statusman.id_status
                       join Client in db.Clients on Order.client equals Client.id_user
                       join Master in db.Masters on Order.master equals Master.id_master
                       //join Computers in db.Computers on Order.computer equals Computers.id_comp
                       where Order.id_order == a
                       select new
                       {
                           Id = Order.id_order,
                           Status = Statusman.status1,
                           Client = Client.id_user + " " + Client.first_name + " " + Client.last_name,
                           //PC = Computers.id_comp + " " + Computers.name + " " + Computers.brand + " " + Computers.model,
                           Master = Master.id_master + " " + Master.first_name + " " + Master.last_name + " " + Master.middle_name,
                           DateAccept = Order.date_of_acceptance,
                           DateRepair = Order.date_of_return,
                           Price = Order.cost,
                           Descpription = Order.description
                       };

            client.Text = data.FirstOrDefault().Client;
            master.Text = data.FirstOrDefault().Master;
            //pc.Text = data.FirstOrDefault().PC;
            status.ItemsSource = LogicStatus.GetStatusManager();
            status.Text = data.FirstOrDefault().Status;
            DateTime? date1 = orders.date_of_acceptance;
            DateTime? date2 = orders.date_of_return;
            accept.SelectedDate = orders.date_of_acceptance;
            @return.SelectedDate = orders.date_of_return;
            price.Text = orders.cost.Value.ToString();
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

                orderr.date_of_acceptance = accept.DisplayDate;
                orderr.date_of_return = @return.DisplayDate;
                orderr.cost = Convert.ToInt32(price.Text);
                orderr.description = description.Text;

                db.SaveChanges();

                MessageBox.Show("Заказ изменён!");
                ViewOrder vo = new ViewOrder();
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
            ViewOrder vo = new ViewOrder();
            vo.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OrderDetailsView odv = new OrderDetailsView(globalid);
            odv.ShowDialog();
        }
    }
}