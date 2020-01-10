using Database;
using Database.EntityModels;
using Logic;
using MahApps.Metro.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class ClientOrderDetailsView : MetroWindow
    {

        object globalid;
        private DataTable dtord = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();
        public ClientOrderDetailsView(int globalid)
        {
            InitializeComponent();
            this.globalid = globalid;
        }



        string connectionString = @"data source=MAX-PC\SQLEXPRESS;initial catalog=ComputerService;integrated security=True;";



        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            string comp1 = "SELECT Parts FROM dbo.Details WHERE [Order] = " + globalid + " AND [Number] = 1";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(comp1, connection);
                var pc11 = command.ExecuteScalar();

                if (pc11 != null)
                {
                    string pc111 = pc11.ToString();
                    dt1 = Logic.LogicComputers.peka(Convert.ToInt32(pc111));
                    pc1.Text = Convert.ToString(dt1.Rows[0].ItemArray[0].ToString());
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    pc1.Visibility = Visibility.Hidden;
                }
            }


            string comp2 = "SELECT Parts FROM dbo.Details WHERE [Order] = " + globalid + " AND [Number] = 2 ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command2 = new SqlCommand(comp2, connection);
                var pc12 = command2.ExecuteScalar();

                if (pc12 != null)
                {
                    string pc122 = pc12.ToString();
                    dt2 = Logic.LogicComputers.peka(Convert.ToInt32(pc122));
                    pc2.Text = Convert.ToString(dt2.Rows[0].ItemArray[0].ToString());
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    pc2.Visibility = Visibility.Hidden;
                }
            }

            string comp3 = "SELECT Parts FROM dbo.Details WHERE [Order] = " + globalid + " AND [Number] = 3 ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command3 = new SqlCommand(comp3, connection);
                var pc13 = command3.ExecuteScalar();

                if (pc13 != null)
                {
                    string pc133 = pc13.ToString();
                    dt3 = Logic.LogicComputers.peka(Convert.ToInt32(pc133));
                    pc3.Text = Convert.ToString(dt3.Rows[0].ItemArray[0].ToString());
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    pc3.Visibility = Visibility.Hidden;
                }
            }

            string comp4 = "SELECT Parts FROM dbo.Details WHERE [Order] = " + globalid + " AND [Number] = 4 ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command4 = new SqlCommand(comp4, connection);
                var pc14 = command4.ExecuteScalar();

                if (pc14 != null)
                {
                    string pc144 = pc14.ToString();
                    dt4 = Logic.LogicComputers.peka(Convert.ToInt32(pc144));
                    pc4.Text = Convert.ToString(dt4.Rows[0].ItemArray[0].ToString());
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    pc4.Visibility = Visibility.Hidden;
                }
            }

            string comp5 = "SELECT Parts FROM dbo.Details WHERE [Order] = " + globalid + " AND [Number] = 5 ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command5 = new SqlCommand(comp5, connection);
                var pc15 = command5.ExecuteScalar();

                if (pc15 != null)
                {
                    string pc155 = pc15.ToString();
                    dt5 = Logic.LogicComputers.peka(Convert.ToInt32(pc155));
                    pc5.Text = Convert.ToString(dt5.Rows[0].ItemArray[0].ToString());
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    pc5.Visibility = Visibility.Hidden;
                }
            }


            dtord = Logic.LogicComputers.GetAllPC();
            viewdgr.ItemsSource = dtord.DefaultView;
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }


    }
}