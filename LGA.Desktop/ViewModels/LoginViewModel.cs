using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LGA.Desktop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Desktop.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {

        private readonly AuthenticationService
            _authenticationService;
        [ObservableProperty]
        private string email = string.Empty;
        [ObservableProperty]
        private string password = string.Empty;
        [ObservableProperty]
        private string errorMessage = string.Empty;
        [RelayCommand]
        private void Login()
        {


            if (string.IsNullOrEmpty(Email)|| string.IsNullOrEmpty(Password))
            {
                ErrorMessage =
                "Please enter your Email and Password.";
                return;
            }

            bool result =
                _authenticationService
                .Authenticate(
                    Email,
                    Password
                );

            if (!result)
            {
                ErrorMessage =
                "Email or Password is incorrect.";
                return;
            }
            ErrorMessage =
                "Login Success";
        }

        public LoginViewModel()
        {
            _authenticationService =
                new AuthenticationService();
        }

    }
}
