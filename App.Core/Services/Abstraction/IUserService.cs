using App.Core.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Services.Abstraction
{
    public interface IUserService
    {
        public Task<bool> Login(string email, string password);
        public Task<bool> Register(string email, string password, string name);
        public Task<bool> UpdateUserDetails(string email, string name);
        public void Logout();
    }
}
