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
    public partial class UpdateComputerMaster : MetroWindow
    {
        public UpdateComputerMaster()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Computers cl = Logic.LogicComputers.GetCurrentPC();
            idtxt.Text = cl.id_comp.ToString();
            name.Text = cl.name;
            model.Text = cl.model;
            brand.Text = cl.brand;
            problem.Text = cl.problem;
            descr.Text = cl.description;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Model1 db = new Model1();
            int a = Convert.ToInt32(idtxt.Text);
            var cls = db.Computers
                .Where(c => c.id_comp == a)
                .FirstOrDefault();

            cls.name = name.Text;
            cls.brand = brand.Text;
            cls.model = model.Text;
            cls.problem = problem.Text;
            cls.description = descr.Text;
            db.SaveChanges();

            MessageBox.Show("Данные о технике изменены!");
            ComputerViewMaster cv = new ComputerViewMaster();
            cv.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ComputerViewMaster cv = new ComputerViewMaster();
            cv.Show();
            Close();
        }
    }
}