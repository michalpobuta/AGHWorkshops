using App.Core.Services;
using App.Core.Services.Abstraction;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.ViewModels
{
    public partial class BaseViewModel : ObservableObject, IQueryAttributable
    {
        protected readonly INavigationService _navigationService;
        protected readonly IUserService _userService;

        public BaseViewModel(INavigationService navigationService, IUserService userService)
        {
            _navigationService=navigationService;
            _userService=userService;
        }

        public virtual void OnAppearing() { }

        public virtual void OnDisappearing() { }

        public virtual void ApplyQuery(IDictionary<string, object> query) { }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            ApplyQuery(query);
        }

        [RelayCommand]
        private async Task Logout() 
        {
            _userService.Logout();
            await _navigationService.GoToLoginPage();
        }
        [RelayCommand]
        private async Task GoBack()
        {
            await _navigationService.GoBack();
        }

    }
}
