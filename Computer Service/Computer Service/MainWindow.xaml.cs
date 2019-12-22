using Database;
using Logic;
using MahApps.Metro.Controls;
using System.Windows;
using System.Windows.Input;

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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Auth.authC(username.Text, password.Password) == true)
            {
                LGS.CurrentID(username.Text, password.Password);

                ClientMain ms = new ClientMain();
                this.Close();
                ms.Show();
            }
            else if (Auth.authM(username.Text, password.Password) == true)
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

        private void Grid_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
            }
        }
    }
}