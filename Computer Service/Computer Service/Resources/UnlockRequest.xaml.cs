using Database.EntityModels;
using Logic;
using MahApps.Metro.Controls;
using System;
using System.Windows;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class UnlockRequest : MetroWindow
    {
        public UnlockRequest()
        {
            InitializeComponent();
            Clients cl = LGS.GetCurrentID();

            //if (cl.block == 1)
            //{
            //    MessageBox.Show("Block!");

            //}
            //else
            //{
            //    MessageBox.Show("Not Block");
            //}


            SaveCLID.CLID = cl.id_user;
            id.Text = SaveCLID.CLID.ToString();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Отправить заявку?", "ВНИМАНИЕ", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                MessageBox.Show("Операция отменена");
            }
            else
            {
                Model1 db = new Model1();

                //пока не сделал
                MessageBox.Show("Заявка отправлена!");
            }
            //try
            //{
            //    Model1 db = new Model1();
            //    Computers cmp = new Computers
            //    {
            //        problem = problem.Text,
            //        brand = brand.Text,
            //        name = equipment.Text,
            //        model = model.Text,
            //        description = description.Text
            //    };
            //    db.Computers.Add(cmp);
            //    db.SaveChanges();
            //    MessageBox.Show("Техника добавлена!");
            //    ComputerView cv = new ComputerView();
            //    cv.Show();
            //    Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Close();
        }
    }
}