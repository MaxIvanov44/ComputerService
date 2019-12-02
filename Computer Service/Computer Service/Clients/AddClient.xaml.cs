﻿using Database.EntityModels;
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
    public partial class AddClient : MetroWindow
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Model1 db = new Model1();
                Clients client = new Clients
                {
                    username = login.Text,
                    password = password.Text,
                    first_name = name.Text,
                    last_name = family.Text,

                    phone = phone.Text
                };
                db.Clients.Add(client);
                db.SaveChanges();
                MessageBox.Show("Клиент добавлен!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
    }
}
