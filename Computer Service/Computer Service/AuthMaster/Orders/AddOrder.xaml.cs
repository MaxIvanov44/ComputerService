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
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void Label_Loaded(object sender, RoutedEventArgs e)
        {
            client.ItemsSource = LogicClient.GetNameClient();
          master.ItemsSource = LogicMaster.GetNameMaster();
           pc.ItemsSource = LogicComputers.GetMark();
           status.ItemsSource = LogicStatus.GetStatus();

        }

        private void viewClient_Click(object sender, RoutedEventArgs e)
        {
            ClientView cv = new ClientView();
            cv.ShowDialog();
        }

        private void viewMaster_Click(object sender, RoutedEventArgs e)
        {
            MasterView mv = new MasterView();
            mv.ShowDialog();

        }

        private void viewCOMP_Click(object sender, RoutedEventArgs e)
        {
            ComputerView cv1 = new ComputerView();
            cv1.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MasterMain mm = new MasterMain();
            mm.Show();
            Close();
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
