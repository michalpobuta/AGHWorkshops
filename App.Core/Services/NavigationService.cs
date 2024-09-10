using App.Core.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Services
{
    public class NavigationService : INavigationService
    {
        public async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        public async Task GoToAsync(string path)
        {
            await Shell.Current.GoToAsync(path);
        }

        public async Task GoToAsync(string path, Dictionary<string, object> parameters)
        {
            await Shell.Current.GoToAsync(path, parameters);
        }

        public async Task GoToLoginPage()
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        public async Task GoToMainPage()
        {
            await Shell.Current.GoToAsync("MainPage");
        }
    }
}
