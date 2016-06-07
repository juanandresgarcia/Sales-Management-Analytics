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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace Sales_Management_Analytics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnLogin(object sender, RoutedEventArgs e)
        {
            string uname = "admin";
            string pw = "admin";

            string _uname = txtboxUname.ToString();
            string _pw = txtboxPw.ToString();

            if (_uname == uname && _pw == pw)
            {
                MessageDialogResult messageResult = await this.ShowMessageAsync("Login Successful", String.Format("Welcome, Admin!"));
            }
            else
            {
                MessageDialogResult messageResult = await this.ShowMessageAsync("Wrong Credentials", String.Format("Please try again..."));
            }            
        }
    }
}
