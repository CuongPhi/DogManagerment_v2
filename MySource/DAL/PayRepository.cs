using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PayRepository : IRepository<PAYMENT_RECEIPT_VOUCHER>
    {
        public PAYMENT_RECEIPT_VOUCHER GetByID(string id)
        {
            using (DMEntities db = new DMEntities())
            {
                return db.PAYMENT_RECEIPT_VOUCHER.Find(int.Parse(id));
            }
        }
        public List<object> search(string id)
        {

            //string upper = id.ToUpper();
            //string lower = id.ToLower();
            //using (DMEntities db = new DMEntities())
            //{
            //    var idbill = (from bill in db.BILL_IN
            //                  let id_bill = bill.ID_BILL
            //                  where
            //               id_bill.StartsWith(lower)
            //               || id_bill.StartsWith(upper)
            //               || id_bill.Contains(id)
            //                  select new
            //                  {
            //                      ID_BILL = bill.ID_BILL
            //                  });

            //    return idbill.ToList().Cast<Object>().ToList();
            //}
            return null;
        }
        public PAYMENT_RECEIPT_VOUCHER GetByIDInt(int id)
        {
            using (DMEntities db = new DMEntities())
            {
                return db.PAYMENT_RECEIPT_VOUCHER.Find(id);
            }
        }
        public int getID(int id)
        {
            using (DMEntities db = new DMEntities())
            {
                var query = (from pay in db.PAYMENT_RECEIPT_VOUCHER where pay.ID_USER == id select new { pay.ID }).ToList();
                return query.Count > 0 ? query[0].ID : -1;
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
            using (DMEntities db = new DMEntities())
            {
                db.PAYMENT_RECEIPT_VOUCHER.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
