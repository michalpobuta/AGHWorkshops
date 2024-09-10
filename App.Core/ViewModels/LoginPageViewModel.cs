using App.Core.Services;
using App.Core.Services.Abstraction;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {

        public LoginPageViewModel(IUserService userService, INavigationService navigationService) : base(navigationService, userService)
        {
        }

        [ObservableProperty]
        private string _email = "";

        [ObservableProperty]
        private string _password = "";


        [RelayCommand]
        private async Task Login() 
        {
            if(await _userService.Login(Email, Password)) 
            {
                await _navigationService.GoToMainPage();
            }     
        }
        [RelayCommand]
        private async Task GoToRegister()
        {
            await _navigationService.GoToAsync("Register");
        }
        public override void OnDisappearing()
        {
            Email = "";
            Password = "";
            base.OnDisappearing();
        }


    }
}
