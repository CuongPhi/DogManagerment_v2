using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Pay_ReceiptRepository : IRepository<PAYMENT_RECEIPT_VOUCHER>
    {
        public PAYMENT_RECEIPT_VOUCHER GetByID(string id)
        {
            using (DMEntities db = new DMEntities())
            {
                return db.PAYMENT_RECEIPT_VOUCHER.Find(int.Parse(id));
            }
        }
        public void Delete(PAYMENT_RECEIPT_VOUCHER obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.PAYMENT_RECEIPT_VOUCHER.Attach(obj);
                db.PAYMENT_RECEIPT_VOUCHER.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }
        public PAYMENT_RECEIPT_VOUCHER Insert(PAYMENT_RECEIPT_VOUCHER obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.PAYMENT_RECEIPT_VOUCHER.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(PAYMENT_RECEIPT_VOUCHER obj)
        {
            throw new NotImplementedException();
        }
    }
}

