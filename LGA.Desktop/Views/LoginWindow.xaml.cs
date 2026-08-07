using LGA.Desktop.Services;
using LGA.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LGA.Desktop.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly AuthenticationService
        _authenticationService;


        private bool showPassword = false;
        public LoginWindow()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
            _authenticationService = new AuthenticationService();
        }

        private void BtnShowPassword_Click(
                object sender,
                RoutedEventArgs e)
        {


            showPassword =
                !showPassword;



            if (showPassword)
            {

                PasswordTextBox.Text =
                    PasswordBox.Password;


                PasswordTextBox.Visibility =
                    Visibility.Visible;


                PasswordBox.Visibility =
                    Visibility.Collapsed;

            }
            else
            {

                PasswordBox.Password =
                    PasswordTextBox.Text;


                PasswordBox.Visibility =
                    Visibility.Visible;


                PasswordTextBox.Visibility =
                    Visibility.Collapsed;

            }

        }

        private void Login_KeyDown(
                object sender,
                System.Windows.Input.KeyEventArgs e)
        {
        }

        private void ForgotPassword_Click(
            object sender,
            RoutedEventArgs e)
        {

            Process.Start(
                new ProcessStartInfo
                {
                    FileName =
                    "https://intuitivebmi.com",

                    UseShellExecute = true
                });

        }

        private void ContactAdministrator_Click(
            object sender,
            RoutedEventArgs e)
        {

            Process.Start(
                new ProcessStartInfo
                {
                    FileName =
                    "https://intuitivebmi.com",

                    UseShellExecute = true
                });

        }
    }
}
