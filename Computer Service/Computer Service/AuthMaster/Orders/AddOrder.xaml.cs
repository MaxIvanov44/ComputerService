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
                Model1 db = new Model1();
                Orders order = new Orders
                {
                    order_status = Convert.ToInt32(LogicStatus.GetIdStatus(status.Text)),
                    client = Convert.ToInt32(LogicClient.GetIdClient(client.Text)),
                    master = Convert.ToInt32(LogicMaster.GetIdMaster(master.Text)),
                    computer = Convert.ToInt32(LogicComputers.GetIdMark(pc.Text)),

                    date_of_acceptance = accept.DisplayDate,
                    date_of_return = @return.DisplayDate,
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
            //  client.ItemsSource = LogicClient.GetNameClient();
            //master.ItemsSource = LogicMaster.GetNameMaster();
            // pc.ItemsSource = LogicComputers.GetMark();
            status.ItemsSource = LogicStatus.GetStatus();

            client.Text = LogicOrders.c;
            master.Text = LogicOrders.m;
            pc.Text = LogicOrders.pc;
        }

        private void viewClient_Click(object sender, RoutedEventArgs e)
        {
            ClientView cv = new ClientView();
            cv.Show();
            Close();
        }

        private void viewMaster_Click(object sender, RoutedEventArgs e)
        {
            MasterView mv = new MasterView();
            mv.Show();
            Close();
        }

        private void viewCOMP_Click(object sender, RoutedEventArgs e)
        {
            ComputerView cv1 = new ComputerView();
            cv1.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MasterMain mm = new MasterMain();
            mm.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            accept.SelectedDate = DateTime.Now;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            @return.SelectedDate = DateTime.Now;
        }

        //public List<Clients> cl { get; set; }
        //void clients()
        //{
        //    Model1 db = new Model1();
        //    var data = db.Clients.ToList();
        //    cl = data;
        //    DataContext = cl;
        //}
    }
}