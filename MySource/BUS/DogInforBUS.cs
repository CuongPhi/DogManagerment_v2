using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public static class DogInforBUS
    {
        static IRepository<DOG_INFOR> reps;
        static DogInforRepository doginf = new DogInforRepository();
        static DogInforBUS()
        {
            reps = new DogInforRepository();
        }
        public static DOG_INFOR Insert(DOG_INFOR obj)
        {
            return reps.Insert(obj);
        }
        public static DOG_INFOR GetById(string id) { return reps.GetByID(id); }

        public static void Update(DOG_INFOR obj)
        {
            reps.Update(obj);
        }
        public static List<Object> GetAll()
        {
            return reps.GetAll();
        }
       public static int getid(int id)
        {
            return doginf.GetIDDog(id);
        }
        public static void Delete(DOG_INFOR obj)
        {
            reps.Delete(obj);
        }
        //public static List<object> search(string id)
        //{
        //    return reps.search(id);
        //}
    }
}
