using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Core.Database.Model;

namespace App.Core.Common
{
    public class UserSession
    {
        public User? CurrentUser { get; set; }
    }
}
