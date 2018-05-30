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
        public static USERAPP GetById(string id) { return reps.GetByID(id); }
        static UserRepository usr = new UserRepository();
        static IRepository<USERAPP> reps;
        public static int GetIdByIDPerson(int id)
        {
            return usr.GetIdByIDPerson(id);
        }
        static UserBUS()
        {
            reps = new UserRepository();
        }
        public static void Update(USERAPP obj)
        {
            reps.Update(obj);
        }
        public static List< Object> GetAll()
        {
            return reps.GetAll();
        }
        public static Object GetAllByUserName(string u)
        {
            return usr.GetAllFromUserName(u);
        }
        public static USERAPP Insert(USERAPP obj)
        {
            return reps.Insert(obj);
        }
        public static void Delete(USERAPP obj)
        {
            reps.Delete(obj);
        }
        public static List<object> search(string name)
        {
            return usr.search(name);
        }
    }
}
