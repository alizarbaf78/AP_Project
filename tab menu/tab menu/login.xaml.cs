﻿using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel.DataAnnotations;

namespace tab_menu
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new Model.Context())
            {
                var res = db.users.Where(i => i.Email == emaill.Text && i.Pass== pass.Password).FirstOrDefault();
                if (res != null)
                {
                    MessageBox.Show("login");
                }
                else
                {
                    MessageBox.Show("wrong data");
                }
            }
        }
    }
}
