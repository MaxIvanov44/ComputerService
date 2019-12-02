using Database.EntityModels;
using Logic;
using Logic.LogicModels;
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
    public partial class UpdateOrder : MetroWindow
    {
        public UpdateOrder()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                client.ItemsSource = LogicClient.GetNameClient();
                master.ItemsSource = LogicMaster.GetNameMaster();
                pc.ItemsSource = LogicComputers.GetMark();
                status.ItemsSource = LogicStatus.GetStatus();

               Orders o = LogicOrders.GetOrders();

                //accept.SelectedDate =
                //Manufacturer.Text = transport.Manufacturer;
                //Model.Text = transport.Model;
                //YearTransport.Text = transport.YearTransport;
                //NumberEngine.Text = transport.NumberEngine;
                //ModelEngine.Text = transport.ModelEngine;
                //YearEngine.Text = transport.YearEngine;
                //PowerEngineK.Text = transport.PowerEngineKVT;
                //PowerEngineH.Text = transport.PowerEngineH;
                //MaxLoad.Text = transport.MaxLoad.ToString();
                //Color.Text = transport.Color;
                //VIN.Text = transport.VIN;
                //Description.Text = transport.Description;
                //CategoryTransport.SelectedIndex = transport.CategoryTransport - 1;
                //TypeOfDrive.SelectedIndex = transport.TypeOfDrive - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
