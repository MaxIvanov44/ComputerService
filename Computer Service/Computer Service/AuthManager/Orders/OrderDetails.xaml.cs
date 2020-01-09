using Database;
using Database.EntityModels;
using Logic;
using MahApps.Metro.Controls;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class OrderDetails : MetroWindow
    {

        object globalid = LogicOrders.globalidorder;
        int count = 1;
        public OrderDetails()
        {
            InitializeComponent();
            LogicComputers.count = 1;
            pc2.Visibility = Visibility.Hidden;
            pc3.Visibility = Visibility.Hidden;
            pc4.Visibility = Visibility.Hidden;
            pc5.Visibility = Visibility.Hidden;
            //pc6.Visibility = Visibility.Hidden;
            //pc7.Visibility = Visibility.Hidden;
            //pc8.Visibility = Visibility.Hidden;
            //pc9.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Model1 db = new Model1();
                //Adding.AddCompl(
                //    Convert.ToInt32(globalid),
                //    Convert.ToInt32(count),
                //    Convert.ToInt32(LogicComputers.GetIdMark(pc1.Text)),
                //    Convert.ToInt32(LogicComputers.GetIdMark(pc2.Text)),
                //    Convert.ToInt32(LogicComputers.GetIdMark(pc3.Text)),
                //    Convert.ToInt32(LogicComputers.GetIdMark(pc4.Text)),
                //    Convert.ToInt32(LogicComputers.GetIdMark(pc5.Text)),
                //    Convert.ToInt32(LogicComputers.GetIdMark(pc6.Text)),
                //    Convert.ToInt32(LogicComputers.GetIdMark(pc7.Text)),
                //    Convert.ToInt32(LogicComputers.GetIdMark(pc8.Text)),
                //    Convert.ToInt32(LogicComputers.GetIdMark(pc9.Text))
                //    );

                switch (count)
                {
                    case 1:
                        Details details1 = new Details
                        {
                            Order = Convert.ToInt32(globalid),
                            Number = 1,
                            Parts = Convert.ToInt32((pc1.Text)),

                        };
                        db.Details.Add(details1);
                        break;
                    case 2:
                        Details details21 = new Details
                        {
                            Order = Convert.ToInt32(globalid),
                            Number = 1,
                            Parts = Convert.ToInt32((pc1.Text)),

                        };
                        db.Details.Add(details21);
                        Details details22 = new Details
                        {
                            Order = Convert.ToInt32(globalid),
                            Number = 2,
                            Parts = Convert.ToInt32((pc2.Text)),

                        };
                        db.Details.Add(details22);
                        break;
                    case 3:
                        Details details31 = new Details
                        {
                            Order = Convert.ToInt32(globalid),
                            Number = 1,
                            Parts = Convert.ToInt32((pc1.Text)),

                        };
                        db.Details.Add(details31);
                        Details details32 = new Details
                        {
                            Order = Convert.ToInt32(globalid),
                            Number = 2,
                            Parts = Convert.ToInt32((pc2.Text)),

                        };
                        db.Details.Add(details32);
                        Details details33 = new Details
                        {
                            Order = Convert.ToInt32(globalid),
                            Number = 3,
                            Parts = Convert.ToInt32((pc3.Text)),

                        };
                        db.Details.Add(details33);
                        break;
                    case 4:
                        Details details41 = new Details
                        {
                            Order = Convert.ToInt32(globalid),
                            Number = 1,
                            Parts = Convert.ToInt32((pc1.Text)),

                        };
                        db.Details.Add(details41);
                        Details details42 = new Details
                        {
                            Order = Convert.ToInt32(globalid),
                            Number = 2,
                            Parts = Convert.ToInt32((pc2.Text)),

                        };
                        db.Details.Add(details42);
                        Details details43 = new Details
                        {
                            Order = Convert.ToInt32(globalid),
                            Number = 3,
                            Parts = Convert.ToInt32((pc3.Text)),

                        };
                        db.Details.Add(details43);
                        Details details44 = new Details
                        {
                            Order = Convert.ToInt32(globalid),
                            Number = 4,
                            Parts = Convert.ToInt32((pc4.Text)),

                        };
                        db.Details.Add(details44);
                        break;
                    case 5:
                        Details details51 = new Details
                        {
                            Order = Convert.ToInt32(globalid),
                            Number = 1,
                            Parts = Convert.ToInt32((pc1.Text)),

                        };
                        db.Details.Add(details51);
                        Details details52 = new Details
                        {
                            Order = Convert.ToInt32(globalid),
                            Number = 2,
                            Parts = Convert.ToInt32((pc2.Text)),

                        };
                        db.Details.Add(details52);
                        Details details53 = new Details
                        {
                            Order = Convert.ToInt32(globalid),
                            Number = 3,
                            Parts = Convert.ToInt32((pc3.Text)),

                        };
                        db.Details.Add(details53);
                        Details details54 = new Details
                        {
                            Order = Convert.ToInt32(globalid),
                            Number = 4,
                            Parts = Convert.ToInt32((pc4.Text)),

                        };
                        db.Details.Add(details54);
                        Details details55 = new Details
                        {
                            Order = Convert.ToInt32(globalid),
                            Number = 5,
                            Parts = Convert.ToInt32((pc5.Text)),

                        };
                        db.Details.Add(details55);
                        break;
                }


                //switch (count)
                //{
                //    case 1:
                //        Details details1 = new Details
                //        {
                //            Order = Convert.ToInt32(globalid),

                //            Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc1.Text)),

                //        };
                //        db.Details.Add(details1);
                //        break;
                //    case 2:
                //        Details details21 = new Details
                //        {
                //            Order = Convert.ToInt32(globalid),

                //            Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc1.Text)),

                //        };
                //        db.Details.Add(details21);
                //        Details details22 = new Details
                //        {
                //            Order = Convert.ToInt32(globalid),

                //            Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc2.Text)),

                //        };
                //        db.Details.Add(details22);
                //        break;
                //    case 3:
                //        Details details31 = new Details
                //        {
                //            Order = Convert.ToInt32(globalid),

                //            Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc1.Text)),

                //        };
                //        db.Details.Add(details31);
                //        Details details32 = new Details
                //        {
                //            Order = Convert.ToInt32(globalid),

                //            Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc2.Text)),

                //        };
                //        db.Details.Add(details32);
                //        Details details33 = new Details
                //        {
                //            Order = Convert.ToInt32(globalid),

                //            Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc3.Text)),

                //        };
                //        db.Details.Add(details33);
                //        break;
                //    case 4:
                //        Details details41 = new Details
                //        {
                //            Order = Convert.ToInt32(globalid),

                //            Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc1.Text)),

                //        };
                //        db.Details.Add(details41);
                //        Details details42 = new Details
                //        {
                //            Order = Convert.ToInt32(globalid),

                //            Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc2.Text)),

                //        };
                //        db.Details.Add(details42);
                //        Details details43 = new Details
                //        {
                //            Order = Convert.ToInt32(globalid),

                //            Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc3.Text)),

                //        };
                //        db.Details.Add(details43);
                //        Details details44 = new Details
                //        {
                //            Order = Convert.ToInt32(globalid),

                //            Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc4.Text)),

                //        };
                //        db.Details.Add(details44);
                //        break;
                //    case 5:
                //        Details details51 = new Details
                //        {
                //            Order = Convert.ToInt32(globalid),

                //            Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc1.Text)),

                //        };
                //        db.Details.Add(details51);
                //        Details details52 = new Details
                //        {
                //            Order = Convert.ToInt32(globalid),

                //            Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc2.Text)),

                //        };
                //        db.Details.Add(details52);
                //        Details details53 = new Details
                //        {
                //            Order = Convert.ToInt32(globalid),

                //            Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc3.Text)),

                //        };
                //        db.Details.Add(details53);
                //        Details details54 = new Details
                //        {
                //            Order = Convert.ToInt32(globalid),

                //            Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc4.Text)),

                //        };
                //        db.Details.Add(details54);
                //        Details details55 = new Details
                //        {
                //            Order = Convert.ToInt32(globalid),

                //            Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc5.Text)),

                //        };
                //        db.Details.Add(details55);
                //        break;
                //}

                //string pc = "1";
                //TextBox[] txt = new TextBox[9];

                //for (int i = 0; i <= count; i++)
                //{
                //    Details details = new Details
                //    {
                //        Order = Convert.ToInt32(globalid),

                //        Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc)),

                //    };
                //    db.Details.Add(details);
                //}
                db.SaveChanges();

                MessageBox.Show("Комплектующие заказа сохранены!");
                //Details details1 = new Details
                //{
                //    Order = Convert.ToInt32(globalid),
                //    Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc1.Text)),

                //};
                //db.Details.Add(details1);
                //Details details2 = new Details
                //{
                //    Order = Convert.ToInt32(globalid),
                //    Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc2.Text)),

                //};
                //db.Details.Add(details2);
                //Details details3 = new Details
                //{
                //    Order = Convert.ToInt32(globalid),
                //    Parts = Convert.ToInt32(LogicComputers.GetIdMark(pc3.Text)),

                //};
                //db.Details.Add(details3);


                //db.SaveChanges();

                //MessageBox.Show("Комплектующие заказа сохранены!");
                AddOrder vo = new AddOrder();
                vo.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddOrder mm = new AddOrder();
            mm.Show();
            Close();
        }

        private void viewCOMP_Click(object sender, RoutedEventArgs e)
        {

            ComputerView cv1 = new ComputerView();
            cv1.Show();
            Close();
        }
        private DataTable dtord = new DataTable();
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            dtord = Logic.LogicComputers.GetAllPC();
            viewdgr.ItemsSource = dtord.DefaultView;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ComputerView cv = new ComputerView();
            cv.ShowDialog();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            count++;
            if (count == 2)
            {
                pc2.Visibility = Visibility.Visible;
            }
            if (count == 3)
            {
                pc3.Visibility = Visibility.Visible;
            }
            if (count == 4)
            {
                pc4.Visibility = Visibility.Visible;
            }
            if (count == 5)
            {
                pc5.Visibility = Visibility.Visible;
                addcompl.IsEnabled = false;
            }
            //if (count == 6)
            //{
            //    pc6.Visibility = Visibility.Visible;
            //}
            //if (count == 7)
            //{
            //    pc7.Visibility = Visibility.Visible;
            //}
            //if (count == 8)
            //{
            //    pc8.Visibility = Visibility.Visible;
            //}
            //if (count == 9)
            //{
            //    pc9.Visibility = Visibility.Visible;

            //}

        }
    }
}