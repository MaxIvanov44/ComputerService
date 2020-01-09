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
    public partial class OrderDetailsView : MetroWindow
    {
        string comp1;
        string addcomp1;
        string comp2;
        string comp3;
        string comp4;
        string comp5;
        object globalid;
        public OrderDetailsView(int globalid)
        {

            InitializeComponent();
            this.globalid = globalid;


        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private DataTable dtord = new DataTable();
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionString = @"data source=MAX-PC\SQLEXPRESS;initial catalog=ComputerService;integrated security=True;";

            string comp1 = "SELECT Parts FROM dbo.Details WHERE [Order] = " + globalid + " AND [Number] = 1 ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand(comp1, connection);
                var pc11 = command1.ExecuteScalar();
                string pc111 = Convert.ToString(pc11);
                if (pc111 != "")
                {

                    //string getcomp1 = "SELECT id_comp,name,brand,model FROM dbo.Computers WHERE id_comp = " + pc111;
                    //using (SqlConnection connect = new SqlConnection(connectionString))
                    //{
                    //    connect.Open();
                    //    SqlCommand com = new SqlCommand(getcomp1, connect);
                    //    var getpc = com.ExecuteScalar();
                    //    addcomp1 = Convert.ToString(getpc);

                    //}



                        //this.comp1 = Convert.ToString(pc111);
                    connection.Close();
                    pc1.Text = pc111;
                    addcomp1 = Convert.ToString(LogicComputers.GetCompl(pc1.Text));
                    pc1.Text = addcomp1;
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
                string pc122 = Convert.ToString(pc12);
                if (pc122 != "")
                {
                    this.comp2 = Convert.ToString(pc122);
                    connection.Close();
                    pc2.Text = this.comp2;
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
                string pc133 = Convert.ToString(pc13);
                if (pc133 != "")
                {

                    this.comp3 = Convert.ToString(pc133);
                    connection.Close();
                    pc3.Text = this.comp3;
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
                string pc144 = Convert.ToString(pc14);
                if (pc144 != "")
                {
                    this.comp4 = Convert.ToString(pc144);
                    connection.Close();
                    pc4.Text = this.comp4;
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
                string pc155 = Convert.ToString(pc15);
                if (pc155 != "")
                {
                    this.comp5 = Convert.ToString(pc155);
                    connection.Close();
                    pc5.Text = this.comp5;
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ComputerView cv = new ComputerView();
            cv.ShowDialog();
            Close();
        }


    }
}