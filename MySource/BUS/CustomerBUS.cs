using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CustomerBUS
    {
        static IRepository<CUSTOMER> reps;
        static CustomerRepository cus = new CustomerRepository();
        static CustomerBUS()
        {
            reps = new CustomerRepository();
        }
        public static int GetIdByIDPerson(int id)
        {
            return cus.GetIdByIDPerson(id);
        }
        public static void Update(CUSTOMER obj)
        {
            reps.Update(obj);
        }
        public static List<Object> GetAll()
        {
            return reps.GetAll();
        }
        public static CUSTOMER Insert(CUSTOMER obj)
        {
            return reps.Insert(obj);
        }
        public static CUSTOMER GetByID(string id)
        {
            return reps.GetByID(id);
        }
        public static void Delete(CUSTOMER obj)
        {
            reps.Delete(obj);
        }
    }
}
