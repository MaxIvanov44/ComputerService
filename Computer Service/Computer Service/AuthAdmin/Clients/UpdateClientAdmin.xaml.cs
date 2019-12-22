using Database.EntityModels;
using MahApps.Metro.Controls;
using System;
using System.Linq;
using System.Windows;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class UpdateClientAdmin : MetroWindow
    {
        public UpdateClientAdmin()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Clients cl = Logic.LogicClient.GetCurrentClient();

            idtxt.Text = cl.id_user.ToString();
            username.Text = cl.username;
            password.Text = cl.password;
            first.Text = cl.first_name;
            last.Text = cl.last_name;
            phone.Text = cl.phone;
            email.Text = cl.email;
            if (cl.block == 1) chk.IsChecked = true;
            else chk.IsChecked = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Model1 db = new Model1();
            int a = Convert.ToInt32(idtxt.Text);
            var cls = db.Clients
                .Where(c => c.id_user == a)
                .FirstOrDefault();

            cls.username = username.Text;
            cls.password = password.Text;
            cls.last_name = last.Text;
            cls.first_name = first.Text;
            cls.phone = phone.Text;
            cls.email = email.Text;
            if (chk.IsChecked == true) cls.block = 1;
            else cls.block = 0;
            db.SaveChanges();

            MessageBox.Show("Данные о клиенте изменены!");
            ClientViewAdmin cv = new ClientViewAdmin();
            cv.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ClientViewAdmin cv = new ClientViewAdmin();
            cv.Show();
            Close();
        }
    }
}