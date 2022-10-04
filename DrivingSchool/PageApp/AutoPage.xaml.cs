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
using DrivingSchool.ClassApp;
namespace DrivingSchool.PageApp
{
    /// <summary>
    /// Логика взаимодействия для AutoPage.xaml
    /// </summary>
    public partial class AutoPage : Page
    {
        public AutoPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if((TextLogin.Text !="")&&(TextPassword.Password !=""))
                    {
                var DataLogin = DbConnection.Connection.Logins.Where
                    (z=>z.login==TextLogin.Text && z.password == TextPassword.Password).FirstOrDefault();
                if(DataLogin!=null)
                {
                    MessageBox.Show($"{DataLogin}","Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Correct \n password");
                }
            }
        }
    }
}
