using Database.EntityModels;
using MahApps.Metro.Controls;
using System;
using System.Windows;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class AddMaster : MetroWindow
    {
        public AddMaster()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Model1 db = new Model1();
                Masters master = new Masters
                {
                    username = login.Text,
                    password = password.Text,
                    first_name = name.Text,
                    last_name = family.Text,
                    middle_name = patronymic.Text,
                    address = address.Text,
                    phone = phone.Text,
                    email = email.Text
                };
                db.Masters.Add(master);
                db.SaveChanges();
                MessageBox.Show("Мастер добавлен!");
                MasterView mv = new MasterView();
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
            MasterView mv = new MasterView();
            mv.Show();
            Close();
        }
    }
}