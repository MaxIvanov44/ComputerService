using Database;
using Logic;
using MahApps.Metro.Controls;
using System.Windows;

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
            username.Visibility = Visibility.Hidden;
            password.Visibility = Visibility.Hidden;
            login1.Visibility = Visibility.Hidden;
            clientsss.Visibility = Visibility.Visible;

            username_Copy.Visibility = Visibility.Hidden;
            password_Copy.Visibility = Visibility.Hidden;
            login2.Visibility = Visibility.Hidden;
            mastersss.Visibility = Visibility.Visible;
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
                AdminMain ms = new AdminMain();
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