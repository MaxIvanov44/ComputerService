using Database.EntityModels;
using MahApps.Metro.Controls;
using System;
using System.Windows;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class AddComputerMaster : MetroWindow
    {
        public AddComputerMaster()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Model1 db = new Model1();
                Computers cmp = new Computers
                {
                    problem = problem.Text,
                    brand = brand.Text,
                    name = equipment.Text,
                    model = model.Text,
                    description = description.Text
                };
                db.Computers.Add(cmp);
                db.SaveChanges();
                MessageBox.Show("Техника добавлена!");
                ComputerViewMaster cv = new ComputerViewMaster();
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
            ComputerViewMaster cv = new ComputerViewMaster();
            cv.Show();
            Close();
        }
    }
}