using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    internal interface IUserRepository
    {
        List<Users> GetAllUser();
        Users AddUser(Users user);
        void DeleteUser(int id);

    }
}
