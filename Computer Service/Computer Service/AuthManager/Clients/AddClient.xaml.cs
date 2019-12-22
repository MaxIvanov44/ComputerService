using Database.EntityModels;
using MahApps.Metro.Controls;
using System;
using System.Windows;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class AddClient : MetroWindow
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Model1 db = new Model1();
                Clients client = new Clients
                {
                    username = login.Text,
                    password = password.Text,
                    first_name = name.Text,
                    last_name = family.Text,
                    phone = phone.Text,
                    email = email.Text
                };
                db.Clients.Add(client);
                db.SaveChanges();
                MessageBox.Show("Клиент добавлен!");
                ClientView cv = new ClientView();
                cv.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ClientView cv = new ClientView();
            cv.Show();
            Close();
        }
    }
}