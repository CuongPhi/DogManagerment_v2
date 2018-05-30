using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public static class PaymentBUS
    {
        static IRepository<PAYMENT_RECEIPT_VOUCHER> reps = new PayRepository();
        static PayRepository pay = new PayRepository();
        public static PAYMENT_RECEIPT_VOUCHER Insert(PAYMENT_RECEIPT_VOUCHER obj)
        {
            return reps.Insert(obj);
        }
        public static PAYMENT_RECEIPT_VOUCHER GetById(string id) { return reps.GetByID(id); }
        public static int getid(int id)//lấy id theo mã nhân viên
        {
            return pay.getID(id);
        }
        public static void Update(PAYMENT_RECEIPT_VOUCHER obj)
        {
            reps.Update(obj);
        }
    }
}
