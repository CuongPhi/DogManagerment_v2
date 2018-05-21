using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class PersonBUS 
    {
        static IRepository<PERSON> reps = new PersonRepository();
        public static PERSON Insert(PERSON obj)
        {
            return reps.Insert(obj);
        }
        public static PERSON GetById(string id) { return reps.GetByID(id); }
        public static void Update(PERSON obj)
        {
            reps.Update(obj);
        }
        public static void Delete(PERSON obj)
        {
            reps.Delete(obj);
        }
    }
}
