using Database;
using Database.EntityModels;
using Logic;
using MahApps.Metro.Controls;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            refreshdata();
            username.Visibility = Visibility.Hidden;
            password.Visibility = Visibility.Hidden;
            login1.Visibility = Visibility.Hidden;
            clientsss.Visibility = Visibility.Visible;

            username_Copy.Visibility = Visibility.Hidden;
            password_Copy.Visibility = Visibility.Hidden;
            login2.Visibility = Visibility.Hidden;
            mastersss.Visibility = Visibility.Visible;
        }

        private void refreshdata()
        {
            Model1 db = new Model1();
            //var data = from Order in db.Orders
            //           join Status in db.Status on Order.order_status equals Status.id_status
            //           join Client in db.Clients on Order.client equals Client.id_user
            //           join Master in db.Masters on Order.master equals Master.id_master
            //           join Computers in db.Computers on Order.computer equals Computers.id_comp
            //           select new
            //           {
            //               Id = Order.id_order,
            //               Status = Status.status1,
            //               Client = Client.first_name + Client.last_name,
            //               PC = Computers.mark + Computers.model,
            //               Master = Master.first_name + Master.last_name + Master.middle_name,
            //               DateAccept = Order.date_of_acceptance,
            //               DateRepair = Order.date_of_return,
            //               Price = Order.repair_price,
            //               Descpription = Order.description

            //           };
            var data = from list in db.PriceList
                       select new
                       {
                           Услуга = list.service,
                           Ценаот = list.price_from,
                           Ценадо = list.price_up
                       };

            pricelistdgr.ItemsSource = data.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Auth.authM(username.Text, password.Password) == true)
            {
                MasterMain ms = new MasterMain();
                this.Close();
                ms.Show();
            }
            else if (Auth.authA(username.Text, password.Password) == true)
            {
                MasterMain ms = new MasterMain();
                this.Close();
                ms.Show();
            }
            else if (Auth.authMan(username.Text, password.Password) == true)
            {
                ManagerMain ms = new ManagerMain();
                this.Close();
                ms.Show();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверны!");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //LGS.CurrentID(username_Copy.Text, password_Copy.Text);

            //ClientMain ms = new ClientMain();
            //this.Close();
            //ms.Show();

            if (Auth.authC(username_Copy.Text, password_Copy.Text) == true)
            {
                LGS.CurrentID(username_Copy.Text.Trim(), password_Copy.Text.Trim());

                ClientMain ms = new ClientMain();
                this.Close();
                ms.Show();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверны!");
            }
        }

        private bool y = true;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (y == true)
            {
                this.Background = new SolidColorBrush(Colors.White);
                color.Background = new SolidColorBrush(Color.FromRgb(64, 73, 82));
                y = false;
            }
            else
            {
                this.Background = new SolidColorBrush(Color.FromRgb(64, 73, 82));
                color.Background = new SolidColorBrush(Colors.White);
                y = true;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            username.Visibility = Visibility.Hidden;
            password.Visibility = Visibility.Hidden;
            login1.Visibility = Visibility.Hidden;
            clientsss.Visibility = Visibility.Hidden;

            username_Copy.Visibility = Visibility.Visible;
            password_Copy.Visibility = Visibility.Visible;
            login2.Visibility = Visibility.Visible;
            mastersss.Visibility = Visibility.Visible;
        }

        private void mastersss_Click(object sender, RoutedEventArgs e)
        {
            username.Visibility = Visibility.Visible;
            password.Visibility = Visibility.Visible;
            login1.Visibility = Visibility.Visible;
            clientsss.Visibility = Visibility.Visible;

            username_Copy.Visibility = Visibility.Hidden;
            password_Copy.Visibility = Visibility.Hidden;
            login2.Visibility = Visibility.Hidden;
            mastersss.Visibility = Visibility.Hidden;
        }
    }
}