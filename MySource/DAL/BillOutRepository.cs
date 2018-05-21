using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillOutRepository : IRepository<BILL_OUT>
    {
        public BILL_OUT GetByID(string id)
        {
            using (DMEntities db = new DMEntities())
            {
                return db.BILL_OUT.Find((id));
            }
        }
        public void Delete(BILL_OUT obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.BILL_OUT.Attach(obj);
                db.BILL_OUT.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }
        public BILL_OUT Insert(BILL_OUT obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.BILL_OUT.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(BILL_OUT obj)
        {
            throw new NotImplementedException();
        }
    }
}

