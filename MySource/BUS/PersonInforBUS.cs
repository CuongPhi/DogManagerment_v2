using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class PersonInforBUS
    {
        static IRepository<PERSONINFOR> reps = new PersonInforRepository();
        public static PERSONINFOR Insert(PERSONINFOR obj)
        {
            return reps.Insert(obj);
        }
        public static PERSONINFOR GetById(string id) { return reps.GetByID(id); }

        public static void Update(PERSONINFOR obj)
        {
            reps.Update(obj);
        }
    }
}
