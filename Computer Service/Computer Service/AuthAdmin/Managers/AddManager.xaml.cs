using Database.EntityModels;
using MahApps.Metro.Controls;
using System;
using System.Windows;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class AddManager : MetroWindow
    {
        public AddManager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Model1 db = new Model1();
                Managers master = new Managers
                {
                    username = login.Text,
                    password = password.Text,
                    first_name = name.Text,
                    last_name = family.Text,
                    middle_name = patronymic.Text,
                    address = address.Text,
                    phone = phone.Text,
                    email = email.Text,
                    serial_passport = serial.Text,
                    number_passport = number.Text
                };
                db.Managers.Add(master);
                db.SaveChanges();
                MessageBox.Show("Менеджер добавлен!");
                ManagerView mv = new ManagerView();
                mv.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ManagerView mv = new ManagerView();
            mv.Show();
            Close();
        }
    }
}