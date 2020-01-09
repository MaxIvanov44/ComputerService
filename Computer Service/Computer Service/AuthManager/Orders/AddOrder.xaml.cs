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
    public partial class AddOrder : MetroWindow
    {
        int statusnew = 1;
        object globalid = 0;
       
        public AddOrder()
        {
            InitializeComponent();
            accept.SelectedDate = DateTime.Now;



            string connectionString = @"data source=MAX-PC\SQLEXPRESS;initial catalog=ComputerService;integrated security=True;";
            string sqlExpression = "SELECT IDENT_CURRENT('dbo.Orders')+1";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                var ident_current = command.ExecuteScalar();
                globalid = ident_current;
                LogicOrders.globalidorder = Convert.ToInt32(globalid);
                connection.Close();
            }



           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                if (@return.Text == "")
                {
                    var dt = DateTime.Now;
                    @return.SelectedDate = dt.AddDays(7);
                }

                if (price.Text == "") price.Text = "0";

                if (description.Text == "") description.Text = "Не указано";

                Model1 db = new Model1();

                Orders order = new Orders
                {
                    order_status = statusnew,
                    //order_status = Convert.ToInt32(LogicStatus.GetIdStatus(status.Text)),
                    client = Convert.ToInt32(LogicClient.GetIdClient(client.Text)),
                    master = Convert.ToInt32(LogicMaster.GetIdMaster(master.Text)),

                    date_of_acceptance = accept.SelectedDate,
                    date_of_return = @return.SelectedDate,
                    cost = Convert.ToInt32(price.Text),
                    description = description.Text
                };
                db.Orders.Add(order);

                //string connectionString = @"data source=MAX-PC\SQLEXPRESS;initial catalog=ComputerService;integrated security=True;";
                //string sqlExpression = "SELECT IDENT_CURRENT('dbo.Orders')+1";
                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    connection.Open();
                //    SqlCommand command = new SqlCommand(sqlExpression, connection);
                //    var ident_current = command.ExecuteScalar();
                //    globalid = ident_current;
                //    LogicOrders.globalidorder = Convert.ToInt32(globalid);
                //}

                //Details details = new Details
                //{
                //    Order = Convert.ToInt32(globalid),
                //    Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc.Text)),

                //};
                //db.Details.Add(details);
                db.SaveChanges();

                MessageBox.Show("Заказ добавлен!");
                ViewOrder vo = new ViewOrder();
                vo.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Label_Loaded(object sender, RoutedEventArgs e)
        {


            client.Text = LogicOrders.c;
            master.Text = LogicOrders.m;
            pc.Text = LogicOrders.pc;

            description.Text = LogicOrders.des;
            price.Text = LogicOrders.pr;
        }

        private void viewClient_Click(object sender, RoutedEventArgs e)
        {


            LogicOrders.pr = price.Text;
            LogicOrders.des = description.Text;
            ClientView cv = new ClientView();
            cv.Show();
            Close();
        }

        private void viewMaster_Click(object sender, RoutedEventArgs e)
        {
            LogicOrders.pr = price.Text;
            LogicOrders.des = description.Text;
            MasterView mv = new MasterView();
            mv.Show();
            Close();
        }

        private void viewCOMP_Click(object sender, RoutedEventArgs e)
        {

            LogicOrders.pr = price.Text;
            LogicOrders.des = description.Text;
            OrderDetails od = new OrderDetails();
            od.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ManagerMain mm = new ManagerMain();
            mm.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            accept.SelectedDate = DateTime.Now;

            LogicOrders.pr = price.Text;
            LogicOrders.des = description.Text;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            @return.SelectedDate = DateTime.Now;

            LogicOrders.pr = price.Text;
            LogicOrders.des = description.Text;
        }


    }
}