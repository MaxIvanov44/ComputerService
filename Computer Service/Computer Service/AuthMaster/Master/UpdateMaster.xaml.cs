﻿using Database.EntityModels;
using Logic;
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
            var cls = db.Clients
                .Where(c => c.id_user == a)
                .FirstOrDefault();


            cls.username = username.Text;
            cls.password = password.Text;
            cls.last_name = last.Text;
            cls.first_name = first.Text;
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