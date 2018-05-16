using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public static class AccountBUS
    {
        static IRepository<ACCOUNT> reps = new AccountRepository();
        static  AccountRepository acc = new AccountRepository();

        static AccountBUS()
        {
            reps = new AccountRepository();
        }
        public static List<ACCOUNT> IsLogin(string u, string p)
        {
            return acc.IsLogin(u, p);
        }
        public static List<Object> GetAll()
        {
            return reps.GetAll();
        }
        public static ACCOUNT Insert(ACCOUNT obj)
        {
            return reps.Insert(obj);
        }
    }
}
