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
    public partial class UpdateMaster : MetroWindow
    {
        public UpdateMaster()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Masters ms = Logic.LogicMaster.GetCurrentMaster();

            idtxt.Text = ms.id_master.ToString();
            username.Text = ms.username;
            password.Text = ms.password;
            first.Text = ms.first_name;
            last.Text = ms.last_name;
            middle.Text = ms.middle_name;
            addr.Text = ms.address;
            phone.Text = ms.phone;
            email.Text = ms.email;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Model1 db = new Model1();
            int a = Convert.ToInt32(idtxt.Text);
            var cls = db.Masters
                .Where(c => c.id_master == a)
                .FirstOrDefault();

            cls.username = username.Text;
            cls.password = password.Text;
            cls.last_name = last.Text;
            cls.first_name = first.Text;
            cls.middle_name = middle.Text;
            cls.address = addr.Text;

            cls.phone = phone.Text;
            cls.email = email.Text;

            db.SaveChanges();

            MessageBox.Show("Данные о мастере изменены!");
            MasterView mv = new MasterView();
            mv.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MasterView mv = new MasterView();
            mv.Show();
            Close();
        }
    }
}