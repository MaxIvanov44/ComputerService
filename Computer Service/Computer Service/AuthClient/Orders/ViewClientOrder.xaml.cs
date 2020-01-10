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
    public partial class ViewClientOrder : MetroWindow
    {
        object globalid;
        object countcompl = 0;
        public ViewClientOrder()
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

            pc.Text = "Количество: " + countcompl;


            var data = from Order in db.Orders
                       join Status in db.Status on Order.order_status equals Status.id_status
                       join Client in db.Clients on Order.client equals Client.id_user
                       join Master in db.Masters on Order.master equals Master.id_master
                       where Order.id_order == a
                       select new
                       {
                           Id = Order.id_order,
                           Status = Status.status1,
                           Client = Client.id_user + " " + Client.first_name + " " + Client.last_name,
                           Master = Master.id_master + " " + Master.first_name + " " + Master.last_name + " " + Master.middle_name,
                           DateAccept = Order.date_of_acceptance,
                           DateRepair = Order.date_of_return,
                           Price = Order.cost,
                           Descpription = Order.description
                       };
            master.Text = data.FirstOrDefault().Master;
            client.Text = data.FirstOrDefault().Client;
            status.Text = data.FirstOrDefault().Status;
            DateTime? date1 = orders.date_of_acceptance;
            DateTime? date2 = orders.date_of_return;
            accept.SelectedDate = orders.date_of_acceptance;
            @return.SelectedDate = orders.date_of_return;
            price.Text = orders.cost.Value.ToString();
            description.Text = orders.description;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewNowOrders vo = new ViewNowOrders();
            vo.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClientOrderDetailsView odv = new ClientOrderDetailsView(Convert.ToInt32(globalid));
            odv.ShowDialog();
        }
    }
}