using App.Core.Common;
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
    public partial class MainPageViewModel : BaseViewModel
    {
        private readonly UserSession _userSession;

        [ObservableProperty]
        private string _name;

        public MainPageViewModel(INavigationService navigationService, IUserService userService, UserSession userSession) : base(navigationService, userService)
        {
            _userSession=userSession;
        }

        public override void OnAppearing()
        {
            Name = _userSession?.CurrentUser?.Name ?? "Guest";
            base.OnAppearing();
        }

        [RelayCommand]
        private async Task GoToProfile() 
        {
            await _navigationService.GoToAsync("Profile");
        }

    }
}
