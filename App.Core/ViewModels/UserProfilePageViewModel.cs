using App.Core.Services.Abstraction;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.ViewModels
{
    public partial class UserProfilePageViewModel : BaseViewModel
    {
        public UserProfilePageViewModel(INavigationService navigationService, IUserService userService) : base(navigationService, userService)
        {
        }



        [RelayCommand]
        private async Task UpdateUser() 
        {
            await _userService.UpdateUserDetails("", "");
        }
        public override void OnAppearing()
        {
            //set user data  
            base.OnAppearing();
        }
        public override void OnDisappearing()
        {
            //clear user data 
            base.OnDisappearing();
        }
    }
}
