using Database.EntityModels;
using Logic.LogicModels;
using MahApps.Metro.Controls;
using System;
using System.Linq;
using System.Windows;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class UpdateManager : MetroWindow
    {
        public UpdateManager()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Managers ms = LogicManagers.GetCurrentManager();

            idtxt.Text = ms.id_manager.ToString();
            username.Text = ms.username;
            password.Text = ms.password;
            first.Text = ms.first_name;
            last.Text = ms.last_name;
            middle.Text = ms.middle_name;
            addr.Text = ms.address;
            phone.Text = ms.phone;
            email.Text = ms.email;
            serial.Text = ms.serial_passport;
            number.Text = ms.middle_name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Model1 db = new Model1();
            int a = Convert.ToInt32(idtxt.Text);
            var cls = db.Managers
                .Where(c => c.id_manager == a)
                .FirstOrDefault();

            cls.username = username.Text;
            cls.password = password.Text;
            cls.last_name = last.Text;
            cls.first_name = first.Text;
            cls.middle_name = middle.Text;
            cls.address = addr.Text;
            cls.phone = phone.Text;
            cls.email = email.Text;
            cls.number_passport = number.Text;
            cls.serial_passport = serial.Text;

            db.SaveChanges();

            MessageBox.Show("Данные о менеджере изменены!");
            ManagerView mv = new ManagerView();
            mv.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ManagerView mv = new ManagerView();
            mv.Show();
            Close();
        }
    }
}