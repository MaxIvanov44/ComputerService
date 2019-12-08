using Database.EntityModels;
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
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
