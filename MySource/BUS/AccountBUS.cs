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
        public static ACCOUNT GetById(string id) { return reps.GetByID(id); }

        static IRepository<ACCOUNT> reps = new AccountRepository();
        public static  AccountRepository acc = new AccountRepository();
        public static void Update(ACCOUNT obj)
        {
            reps.Update(obj);
        }
       public static void ChangePassword(ACCOUNT obj, string newPass)
        {
            obj.PASSWORD = newPass;
            reps.Update(obj);
        }
        public static ACCOUNT Insert(ACCOUNT obj)
        {
            return reps.Insert(obj);
        }
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
        public static void ResetPass(string userName, string newPass)
        {
            ACCOUNT obj = reps.GetByID(userName);
            obj.PASSWORD = newPass;
            reps.Update(obj);
        }
        public static bool BanAccount(string userName, bool isLock)
        {
            ACCOUNT obj = reps.GetByID(userName);
            if(obj.ISBAN != isLock)
            {
                obj.ISBAN = isLock;
                acc.Update(obj);
                return true; ;
            }            
            return false;
        }
        
    }
}
