using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonInforRepository : IRepository<PERSONINFOR>
    {
        public PERSONINFOR GetByID(string id)
        {
            using (DMEntities db = new DMEntities())
            {
                return db.PERSONINFORs.Find(id);
            }
        }
        public void Delete(PERSONINFOR obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.PERSONINFORs.Attach(obj);
                db.PERSONINFORs.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public PERSONINFOR Insert(PERSONINFOR obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.PERSONINFORs.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(PERSONINFOR obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.PERSONINFORs.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
