using Database.EntityModels;
using Logic;
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
    public partial class ViewNowOrders: MetroWindow
    {
        public ViewNowOrders()
        {
            InitializeComponent();
            var id = SaveCLID.CLID;
            Model1 db = new Model1();
           var data = from Order in db.Orders
            join Status in db.Status on Order.order_status equals Status.id_status
            join Client in db.Clients on Order.client equals Client.id_user
            join Master in db.Masters on Order.master equals Master.id_master
            join Computers in db.Computers on Order.computer equals Computers.id_comp
            where Order.client == id
                       select new
                       {
                           ID = Order.id_order,
                           Статус = Status.status1,
                           Техника = Computers.name + " - " + Computers.brand + " " + Computers.model,
                           Мастер = Master.first_name + " " + Master.last_name + " " + Master.middle_name,
                           Дата_принятия = Order.date_of_acceptance,
                           Дата_возврата = Order.date_of_return,
                           Стоимость = Order.repair_price,
                           Описание = Order.description

                       };
            viewdgr.ItemsSource = data.ToList();



        }


        private void viewdgr_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Logic.LogicOrders.CurrentOrder(Convert.ToInt32(dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString()
                ));
            UpdateOrder upd = new UpdateOrder();
            upd.Show();
            Close();

        }
        DataTable dtord = new DataTable();
        private void viewdgr_Loaded(object sender, RoutedEventArgs e)
        {
            //dtord = Logic.LogicOrders.AllClientOrders(SaveCLID.CLID);
            //viewdgr.ItemsSource = dtord.DefaultView;

        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            Logic.LogicOrders.CurrentOrder(Convert.ToInt32(dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString()
               ));
            UpdateOrder upd = new UpdateOrder();
            upd.Show();
            Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            ClientMain mm = new ClientMain();
            mm.Show();
            Close();
        }

        private void new_Checked(object sender, RoutedEventArgs e)
        {
            if (@new.IsChecked == true)
            {
                var id = SaveCLID.CLID;
                Model1 db = new Model1();
                var data = from Order in db.Orders
                           join Status in db.Status on Order.order_status equals Status.id_status
                           join Client in db.Clients on Order.client equals Client.id_user
                           join Master in db.Masters on Order.master equals Master.id_master
                           join Computers in db.Computers on Order.computer equals Computers.id_comp
                           where Order.client == id && Order.order_status == 1
                           select new
                           {
                               ID = Order.id_order,
                               Статус = Status.status1,
                               Техника = Computers.name + " - " + Computers.brand + " " + Computers.model,
                               Мастер = Master.first_name + " " + Master.last_name + " " + Master.middle_name,
                               Дата_принятия = Order.date_of_acceptance,
                               Дата_возврата = Order.date_of_return,
                               Стоимость = Order.repair_price,
                               Описание = Order.description

                           };
                viewdgr.ItemsSource = data.ToList();
            }

        }

        private void inprocess_Checked(object sender, RoutedEventArgs e)
        {
            if (inprocess.IsChecked == true)
            {
                var id = SaveCLID.CLID;
                Model1 db = new Model1();
                var data = from Order in db.Orders
                           join Status in db.Status on Order.order_status equals Status.id_status
                           join Client in db.Clients on Order.client equals Client.id_user
                           join Master in db.Masters on Order.master equals Master.id_master
                           join Computers in db.Computers on Order.computer equals Computers.id_comp
                           where Order.client == id && Order.order_status == 2
                           select new
                           {
                               ID = Order.id_order,
                               Статус = Status.status1,
                               Техника = Computers.name + " - " + Computers.brand + " " + Computers.model,
                               Мастер = Master.first_name + " " + Master.last_name + " " + Master.middle_name,
                               Дата_принятия = Order.date_of_acceptance,
                               Дата_возврата = Order.date_of_return,
                               Стоимость = Order.repair_price,
                               Описание = Order.description

                           };
                viewdgr.ItemsSource = data.ToList();
            }

        }

        private void cancel_Checked(object sender, RoutedEventArgs e)
        {
            if (cancel.IsChecked == true)
            {
                var id = SaveCLID.CLID;
                Model1 db = new Model1();
                var data = from Order in db.Orders
                           join Status in db.Status on Order.order_status equals Status.id_status
                           join Client in db.Clients on Order.client equals Client.id_user
                           join Master in db.Masters on Order.master equals Master.id_master
                           join Computers in db.Computers on Order.computer equals Computers.id_comp
                           where Order.client == id && Order.order_status == 3
                           select new
                           {
                               ID = Order.id_order,
                               Статус = Status.status1,
                               Техника = Computers.name + " - " + Computers.brand + " " + Computers.model,
                               Мастер = Master.first_name + " " + Master.last_name + " " + Master.middle_name,
                               Дата_принятия = Order.date_of_acceptance,
                               Дата_возврата = Order.date_of_return,
                               Стоимость = Order.repair_price,
                               Описание = Order.description

                           };
                viewdgr.ItemsSource = data.ToList();
            }

        }

        private void ready_Checked(object sender, RoutedEventArgs e)
        {
            if (ready.IsChecked == true)
            {
                var id = SaveCLID.CLID;
                Model1 db = new Model1();
                var data = from Order in db.Orders
                           join Status in db.Status on Order.order_status equals Status.id_status
                           join Client in db.Clients on Order.client equals Client.id_user
                           join Master in db.Masters on Order.master equals Master.id_master
                           join Computers in db.Computers on Order.computer equals Computers.id_comp
                           where Order.client == id && Order.order_status == 4
                           select new
                           {
                               ID = Order.id_order,
                               Статус = Status.status1,
                               Техника = Computers.name + " - " + Computers.brand + " " + Computers.model,
                               Мастер = Master.first_name + " " + Master.last_name + " " + Master.middle_name,
                               Дата_принятия = Order.date_of_acceptance,
                               Дата_возврата = Order.date_of_return,
                               Стоимость = Order.repair_price,
                               Описание = Order.description

                           };
                viewdgr.ItemsSource = data.ToList();
            }

        }

        private void complete_Checked(object sender, RoutedEventArgs e)
        {
            if (complete.IsChecked == true)
            {
                var id = SaveCLID.CLID;
                Model1 db = new Model1();
                var data = from Order in db.Orders
                           join Status in db.Status on Order.order_status equals Status.id_status
                           join Client in db.Clients on Order.client equals Client.id_user
                           join Master in db.Masters on Order.master equals Master.id_master
                           join Computers in db.Computers on Order.computer equals Computers.id_comp
                           where Order.client == id && Order.order_status == 5
                           select new
                           {
                               ID = Order.id_order,
                               Статус = Status.status1,
                               Техника = Computers.name + " - " + Computers.brand + " " + Computers.model,
                               Мастер = Master.first_name + " " + Master.last_name + " " + Master.middle_name,
                               Дата_принятия = Order.date_of_acceptance,
                               Дата_возврата = Order.date_of_return,
                               Стоимость = Order.repair_price,
                               Описание = Order.description

                           };
                viewdgr.ItemsSource = data.ToList();
            }

        }

        private void all_Checked(object sender, RoutedEventArgs e)
        {
            if (all.IsChecked == true)
            {
                var id = SaveCLID.CLID;
                Model1 db = new Model1();
                var data = from Order in db.Orders
                           join Status in db.Status on Order.order_status equals Status.id_status
                           join Client in db.Clients on Order.client equals Client.id_user
                           join Master in db.Masters on Order.master equals Master.id_master
                           join Computers in db.Computers on Order.computer equals Computers.id_comp
                           where Order.client == id
                           select new
                           {
                               ID = Order.id_order,
                               Статус = Status.status1,
                               Техника = Computers.name + " - " + Computers.brand + " " + Computers.model,
                               Мастер = Master.first_name + " " + Master.last_name + " " + Master.middle_name,
                               Дата_принятия = Order.date_of_acceptance,
                               Дата_возврата = Order.date_of_return,
                               Стоимость = Order.repair_price,
                               Описание = Order.description

                           };
                viewdgr.ItemsSource = data.ToList();
            }
        }


    }
}
