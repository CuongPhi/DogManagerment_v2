using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountRepository : IRepository<ACCOUNT>
    {
        public ACCOUNT GetByID(string id)
        {
            using (DMEntities db = new DMEntities())
            {
                return db.ACCOUNTs.Find(id);
            }
        }
        public void Delete(ACCOUNT obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.ACCOUNTs.Attach(obj);
                db.ACCOUNTs.Remove(obj);
                db.SaveChanges();
            }
        }
            public List<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public  ACCOUNT Insert(ACCOUNT obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.ACCOUNTs.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }
        public List< ACCOUNT> IsLogin(string u, string p)
        {
            using (DMEntities db = new DMEntities())
            {

                return (from acc in db.ACCOUNTs.ToList()
                        where (acc.USERNAME.Equals(u) && acc.PASSWORD.Equals(p) && acc.ISBAN == false)
                        select new ACCOUNT
                            {
                               USERNAME= acc.USERNAME,
                               TYPE =   acc.TYPE,
                               ID_USER = acc.ID_USER,
                               PASSWORD=null,
                               PASSWORD2= null
                        }).ToList();
            }
        }

        public void Update(ACCOUNT obj)
        {
            throw new NotImplementedException();
        }
    }
}
