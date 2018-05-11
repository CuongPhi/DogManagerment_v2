using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public static class UserBUS
    {
        static IUserRepository reps;
        static UserBUS()
        {
            reps = new UserRepository();
        }
        public static List< Object> GetAll()
        {
            return reps.GetAll();
        }
        public static USERAPP Insert(USERAPP obj)
        {
            return reps.Insert(obj);
        }
    }
}
