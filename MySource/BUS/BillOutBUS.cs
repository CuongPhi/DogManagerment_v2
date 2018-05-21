using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BillOutBUS
    {
        static IRepository<BILL_OUT> reps;
        static BillOutBUS()
        {
            reps = new BillOutRepository();
        }
        public static void Update(BILL_OUT obj)
        {
            reps.Update(obj);
        }
        public static List<Object> GetAll()
        {
            return reps.GetAll();
        }
        public static BILL_OUT Insert(BILL_OUT obj)
        {
            return reps.Insert(obj);
        }
        public static BILL_OUT GetByID(string id)
        {
            return reps.GetByID(id);
        }
        public static void Delete(BILL_OUT obj)
        {
            reps.Delete(obj);
        }
    }
}
