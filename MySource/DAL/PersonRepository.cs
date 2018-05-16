using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonRepository : IRepository<PERSON>
    {
        public PERSON GetByID(string id)
        {
            using (DMEntities db = new DMEntities())
            {
                return db.People.Find(int.Parse(id));
            }
        }
        public void Delete(PERSON obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.People.Attach(obj);
                db.People.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public PERSON Insert(PERSON obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.People.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(PERSON obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.People.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
    }
}
