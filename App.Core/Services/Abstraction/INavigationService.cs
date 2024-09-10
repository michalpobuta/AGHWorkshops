using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Services.Abstraction
{
    public  interface INavigationService
    {
        Task GoBack();
        Task GoToAsync(string path);
        Task GoToAsync(string path, Dictionary<string, object> parameters);
        Task GoToLoginPage();
        Task GoToMainPage();
    }
}
