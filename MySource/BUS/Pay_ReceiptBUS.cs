using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class Pay_ReceiptBUS
    {
        static IRepository<PAYMENT_RECEIPT_VOUCHER> reps;
        static Pay_ReceiptBUS()
        {
            reps = new Pay_ReceiptRepository();
        }
        public static void Update(PAYMENT_RECEIPT_VOUCHER obj)
        {
            reps.Update(obj);
        }
        public static List<Object> GetAll()
        {
            return reps.GetAll();
        }
        public static PAYMENT_RECEIPT_VOUCHER Insert(PAYMENT_RECEIPT_VOUCHER obj)
        {
            return reps.Insert(obj);
        }
        public static PAYMENT_RECEIPT_VOUCHER GetByID(string id)
        {
            return reps.GetByID(id);
        }
        public static void Delete(PAYMENT_RECEIPT_VOUCHER obj)
        {
            reps.Delete(obj);
        }
    }
}
