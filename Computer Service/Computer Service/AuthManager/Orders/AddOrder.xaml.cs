using Database.EntityModels;
using Logic;
using MahApps.Metro.Controls;
using System;
using System.Windows;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class AddOrder : MetroWindow
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (accept.Text == "") accept.SelectedDate = DateTime.Now;

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
                    order_status = Convert.ToInt32(LogicStatus.GetIdStatus(status.Text)),
                    client = Convert.ToInt32(LogicClient.GetIdClient(client.Text)),
                    master = Convert.ToInt32(LogicMaster.GetIdMaster(master.Text)),
                    computer = Convert.ToInt32(LogicComputers.GetIdMark(pc.Text)),

                    date_of_acceptance = accept.SelectedDate,
                    date_of_return = @return.SelectedDate,
                    repair_price = Convert.ToInt32(price.Text),
                    description = description.Text
                };
                db.Orders.Add(order);
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
            status.ItemsSource = LogicStatus.GetStatusMaster();

            client.Text = LogicOrders.c;
            master.Text = LogicOrders.m;
            pc.Text = LogicOrders.pc;

            description.Text = LogicOrders.des;
            price.Text = LogicOrders.pr;
        }

        private void viewClient_Click(object sender, RoutedEventArgs e)
        {
            LogicOrders.st = status.Text;

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
            ComputerView cv1 = new ComputerView();
            cv1.Show();
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

        private void status_ContextMenuClosing(object sender, System.Windows.Controls.ContextMenuEventArgs e)
        {
            LogicOrders.pr = price.Text;
            LogicOrders.des = description.Text;
        }

        private void status_ContextMenuOpening(object sender, System.Windows.Controls.ContextMenuEventArgs e)
        {
            LogicOrders.pr = price.Text;
            LogicOrders.des = description.Text;
        }
    }
}