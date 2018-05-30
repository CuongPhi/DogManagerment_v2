using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DogInforRepository : IRepository<DOG_INFOR>
    {
        public DOG_INFOR GetByID(string id)
        {
            using (DMEntities db = new DMEntities())
            {
                return db.DOG_INFOR.Find(int.Parse(id));
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
        public int GetIDDog(int idDog)
        {
            using (DMEntities db = new DMEntities())
            {
                var query = (from doginf in db.DOG_INFOR where doginf.IDDOG == idDog select new { doginf.ID }).ToList();
                return query.Count > 0 ? query[0].ID : -1;
            }
        }
        public void Delete(DOG_INFOR obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.DOG_INFOR.Attach(obj);
                db.DOG_INFOR.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public DOG_INFOR Insert(DOG_INFOR obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.DOG_INFOR.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(DOG_INFOR obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.DOG_INFOR.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
