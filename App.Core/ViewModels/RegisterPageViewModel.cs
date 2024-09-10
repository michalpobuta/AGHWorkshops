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
    public partial class RegisterPageViewModel : BaseViewModel
    {
        public RegisterPageViewModel(INavigationService navigationService, IUserService userService) : base(navigationService, userService)
        {
        }

        [ObservableProperty]
        private string _email = "";
        [ObservableProperty]
        private string _password = "";
        [ObservableProperty]
        private string _name = "";



        [RelayCommand]
        private async Task Register() 
        {
            if (await _userService.Register(Email,Password,Name)) 
            {
                await _navigationService.GoToMainPage();
            }
        }

        public override void OnDisappearing()
        {
            Email = "";
            Password = "";
            Name = "";
            base.OnDisappearing();
        }
    }
}
