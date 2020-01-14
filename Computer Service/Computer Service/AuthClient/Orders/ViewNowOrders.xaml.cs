using Database.EntityModels;
using GemBox.Spreadsheet;
using Logic;
using MahApps.Metro.Controls;
using Microsoft.Win32;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class ViewNowOrders : MetroWindow
    {
        public ViewNowOrders()
        {
            InitializeComponent();
        }

        private DataTable dtord = new DataTable();

        private void viewdgr_Loaded(object sender, RoutedEventArgs e)
        {
            dtord = Logic.LogicOrders.AllClientOrders(SaveCLID.CLID);
            viewdgr.ItemsSource = dtord.DefaultView;
        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            Logic.LogicOrders.CurrentOrder(Convert.ToInt32(dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString()
               ));
            ViewClientOrder upd = new ViewClientOrder();
            upd.Show();
            Close();
        }
        private void viewdgr_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Logic.LogicOrders.CurrentOrder(Convert.ToInt32(dtord.Rows[viewdgr.SelectedIndex].ItemArray[0].ToString()
                ));
            ViewClientOrder upd = new ViewClientOrder();
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
                           where Order.client == id && Order.order_status == 1
                           select new
                           {
                               ID = Order.id_order,
                               Статус = Status.status1,
                               Мастер = Master.first_name + " " + Master.last_name + " " + Master.middle_name,
                               Дата_принятия = Order.date_of_acceptance,
                               Дата_возврата = Order.date_of_return,
                               Стоимость = Order.cost,
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
                           where Order.client == id && Order.order_status == 2
                           select new
                           {
                               ID = Order.id_order,
                               Статус = Status.status1,
                               Мастер = Master.first_name + " " + Master.last_name + " " + Master.middle_name,
                               Дата_принятия = Order.date_of_acceptance,
                               Дата_возврата = Order.date_of_return,
                               Стоимость = Order.cost,
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
                           where Order.client == id && Order.order_status == 3
                           select new
                           {
                               ID = Order.id_order,
                               Статус = Status.status1,
                               Мастер = Master.first_name + " " + Master.last_name + " " + Master.middle_name,
                               Дата_принятия = Order.date_of_acceptance,
                               Дата_возврата = Order.date_of_return,
                               Стоимость = Order.cost,
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
                           where Order.client == id && Order.order_status == 4
                           select new
                           {
                               ID = Order.id_order,
                               Статус = Status.status1,
                               Мастер = Master.first_name + " " + Master.last_name + " " + Master.middle_name,
                               Дата_принятия = Order.date_of_acceptance,
                               Дата_возврата = Order.date_of_return,
                               Стоимость = Order.cost,
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
                           where Order.client == id && Order.order_status == 5
                           select new
                           {
                               ID = Order.id_order,
                               Статус = Status.status1,
                               Мастер = Master.first_name + " " + Master.last_name + " " + Master.middle_name,
                               Дата_принятия = Order.date_of_acceptance,
                               Дата_возврата = Order.date_of_return,
                               Стоимость = Order.cost,
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
                           where Order.client == id
                           select new
                           {
                               ID = Order.id_order,
                               Статус = Status.status1,
                               Мастер = Master.first_name + " " + Master.last_name + " " + Master.middle_name,
                               Дата_принятия = Order.date_of_acceptance,
                               Дата_возврата = Order.date_of_return,
                               Стоимость = Order.cost,
                               Описание = Order.description
                           };
                viewdgr.ItemsSource = data.ToList();
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            var workbook = new ExcelFile();
            var worksheet = workbook.Worksheets.Add("dtord");


            // Insert DataTable to an Excel worksheet.
            worksheet.InsertDataTable(dtord,
                new InsertDataTableOptions()
                {
                    ColumnHeaders = true,


                });

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xls)|*.xls|Excel files (*.csv)|*.csv|HTML files (*.html)|*.html|PDF files (*.pdf)|*.pdf|JPEG files (*.jpeg)|*.jpeg|GIF files (*.gif)|*.gif";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, viewdgr.Background.ToString());
                workbook.Save(saveFileDialog.FileName);
                MessageBox.Show("Отчет сохранен в  " + saveFileDialog.FileName);
            }
            else
            {

            }

        }
    }
}