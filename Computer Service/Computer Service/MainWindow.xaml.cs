using Database;
using Database.EntityModels;
using Logic;
using MahApps.Metro.Controls;
using Microsoft.Data.ConnectionUI;
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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Auth.authC(username.Text, password.Password) == true)
            {
                LGS.CurrentID(username.Text, password.Password);
                Clients cl = LGS.GetCurrentID();
                SaveCLID.CLID = cl.id_user;
                if (cl.block == 1)
                {
                    if (MessageBox.Show("Хотите оставить заявку на разблокировку?", "ВНИМАНИЕ: Клиент заблокирован", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                    {
                        this.Close();
                    }
                    else
                    {
                        UnlockRequest ur = new UnlockRequest();
                        this.Close();
                        ur.Show();
                    }
                }
                else if (cl.block == 0)
                {
                    ClientMain ms = new ClientMain();
                    this.Close();
                    ms.Show();
                }
            }
            else if (Auth.authM(username.Text, password.Password) == true)
            {
                LGS.MasterID(username.Text, password.Password);
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            DataSource sqlDataSource = new DataSource("MicrosoftSqlServer", "Microsoft SQL Server");
            sqlDataSource.Providers.Add(DataProvider.SqlDataProvider);
            DataConnectionDialog dcd = new DataConnectionDialog();
            dcd.DataSources.Add(sqlDataSource);
            dcd.SelectedDataProvider = DataProvider.SqlDataProvider;
            dcd.SelectedDataSource = sqlDataSource;

                string connectionString = dcd.ConnectionString;

        }
    }
}