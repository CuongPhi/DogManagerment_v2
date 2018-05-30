using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class BillinRepository : IRepository<BILL_IN>
    {
        public BILL_IN GetByID(string id)
        {
            using (DMEntities db = new DMEntities())
            {
                return db.BILL_IN.Find(id);
            }
        }

        public string GetIdByIDBill(string id)
        {
            using (DMEntities db = new DMEntities())
            {
                var query = (from bill in db.BILL_IN where bill.ID_BILL == id select new { bill.ID_BILL }).ToList();
                return query.Count > 0 ? query[0].ID_BILL : "";
            }
        }
        public void Delete(BILL_IN obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.BILL_IN.Attach(obj);
                db.BILL_IN.Remove(obj);
                db.SaveChanges();
            }
        }
        public List<string> GetListBill()
        {
            using (DMEntities db = new DMEntities())
            {
                var query = (from bill in db.BILL_IN
                             select new
                             {
                                 ID_BILL = bill.ID_BILL,

                             });
                return query.ToList().Cast<string>().ToList();

            }
        }
        public List<object> search(string id)
        {

            string upper = id.ToUpper();
            string lower = id.ToLower();
            using (DMEntities db = new DMEntities())
            {
                var idbill = (from bill in db.BILL_IN
                              let id_bill = bill.ID_BILL
                              join dog in db.DOGs on bill.IDDOG equals dog.ID
                              join doginf in db.DOG_INFOR on dog.ID equals doginf.IDDOG
                              where
                           id_bill.StartsWith(lower)
                           || id_bill.StartsWith(upper)
                           || id_bill.Contains(id)
                              select new
                              {
                                  bill.ID_BILL,
                                  bill.ID_USER,
                                  ID_DOG = bill.IDDOG,
                                  IDDOGHOUSE = dog.IDDOGHOUSE,
                                  DAY_BILL = bill.DAY_BILL,
                                  WEIGHT = dog.WEIGHT,
                                  FOODPRICE = dog.FOODPRICE,
                                  STREET = doginf.STREET,
                                  WARD = doginf.WARD,
                                  DISTRICT = doginf.DISTRICT,
                                  TIMER = doginf.TIME,
                                  TYPE = dog.TYPE,
                                  FINE = bill.FINE
                              });

                return idbill.ToList().Cast<Object>().ToList();
            }
        }
                

           
        public List<Object> GetAll()
        {

            using (DMEntities db = new DMEntities())
            {
                
                var query = (from dog in db.DOGs
                             join dogif in db.DOG_INFOR on dog.ID equals dogif.IDDOG
                            
                             join bill in db.BILL_IN on dog.ID equals bill.IDDOG
                             select new
                             {
                                 bill.ID_BILL,
                                bill.ID_USER,
                                ID_DOG = bill.IDDOG,
                                IDDOGHOUSE = dog.IDDOGHOUSE,
                                DAY_BILL=bill.DAY_BILL,
                                WEIGHT = dog.WEIGHT,
                                 FOODPRICE = dog.FOODPRICE,
                                 STREET = dogif.STREET,
                                 WARD = dogif.WARD,
                                 DISTRICT = dogif.DISTRICT,
                                 TIMER = dogif.TIME,
                                 TYPE = dog.TYPE,
                                 FINE = bill.FINE
                             });
                return query.ToList().Cast<Object>().ToList();
            }
        }
       
        public BILL_IN Insert(BILL_IN obj)
        {
            using (DMEntities db = new DMEntities())
            {
                
                db.BILL_IN.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(BILL_IN obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.BILL_IN.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
