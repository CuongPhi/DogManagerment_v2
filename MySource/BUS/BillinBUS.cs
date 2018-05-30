using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public static class BillinBUS
    {
        public static BILL_IN GetById(string id) { return reps.GetByID(id); }
        static BillinRepository bill = new BillinRepository();
        static IRepository<BILL_IN> reps;
        public static string GetIdByIDBill(string id)
        {
            return bill.GetIdByIDBill(id);
        }
        static BillinBUS()
        {
            reps = new BillinRepository();
        }
        public static void Update(BILL_IN obj)
        {
            reps.Update(obj);
        }
        public static List<object> GetAll()
        {
            return reps.GetAll();
        }
        public static BILL_IN Insert(BILL_IN obj)
        {
            return reps.Insert(obj);
        }
        public static void Delete(BILL_IN obj)
        {
            reps.Delete(obj);
        }
        public static List<string> getBill()
        {
            return bill.GetListBill();
        }
        public static List<object> search(string id)
        {
            return bill.search(id);
        }
    }
}
