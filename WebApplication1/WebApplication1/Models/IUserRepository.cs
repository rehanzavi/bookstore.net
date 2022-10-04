using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    internal interface IUserRepository
    {
        List<User> GetAllUser();
        User AddUser(User user);
        void DeleteUser(int id);

    }
}
