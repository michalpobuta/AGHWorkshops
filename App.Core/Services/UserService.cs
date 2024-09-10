using App.Core.Common;
using App.Core.Database.Model;
using App.Core.Database.Repositories;
using App.Core.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IHashService hashService;
        private readonly IBaseRepository<User> userRepository;
        private UserSession userSession;

        public UserService(IHashService hashService, IBaseRepository<User> userRepository, UserSession userSession)
        {
            this.hashService = hashService;
            this.userRepository = userRepository;
            this.userSession = userSession;
        }

        public async Task<bool> Login(string email, string password)
        {
            if(String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password)) 
            {
                return false;
            }

            var user = (await userRepository.GetItems(x => x.Email.Equals(email)))?.FirstOrDefault();
            if (user!= null)
            {
                if (hashService.Verify(password, user.Password))
                {
                    userSession.CurrentUser = user;
                    await userRepository.UpdateItem(user);
                    return true;
                }
            }
            return false;
        }

        public void Logout()
        {
            userSession.CurrentUser = null;
        }

        public async Task<bool> Register(string email, string password, string name)
        {
            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(name))
            {
                return false;
            }

            var user = new User() { Id = 0, Email = email, Password = hashService.Hash(password), Name = name };
            
                if (!(await userRepository.GetItems(x => x.Email.Equals(user.Email))).Any())
                {
                    var newUser = await userRepository.SaveItem(user);
                    userSession.CurrentUser = newUser;
                    return true;
                }

            return false;
        }
        public async Task<bool> UpdateUserDetails(string email, string name)
        {
            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(name))
            {
                return false;
            }
            try
            {
                userSession.CurrentUser!.Email = email;
                userSession.CurrentUser!.Name = name;

                await userRepository.UpdateItem(userSession!.CurrentUser);
            }
            catch (Exception ex) 
            {
                return false;
            }

            return true;
        }
    }
}
