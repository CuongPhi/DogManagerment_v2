using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class DogBUS
    {
        static IRepository<DOG> reps;
        static DogBUS()
        {
            reps = new DogRepository();
        }
        public static void Update(DOG obj)
        {
            reps.Update(obj);
        }
        public static List<Object> GetAll()
        {
            return reps.GetAll();
        }
        public static DOG Insert(DOG obj)
        {
            return reps.Insert(obj);
        }

    }
}
