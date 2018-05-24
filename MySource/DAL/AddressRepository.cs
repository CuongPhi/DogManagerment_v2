using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AddressRepository: IRepository<ADDRESS>
    {
        public ADDRESS GetByID(string id)
        {
            using (DMEntities db = new DMEntities())
            {
                return db.ADDRESSes.Find(int.Parse(id));
            }
        }
        public ADDRESS GetByIDPerson(string idPerinf)
        {
            using (DMEntities db = new DMEntities())
            {
                var query = (from a in db.ADDRESSes where a.IDPERSON == idPerinf select new { a.ID }).ToList();
                return GetByID(query[0].ID.ToString());
            }
        }
        public void Delete(ADDRESS obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.ADDRESSes.Attach(obj);
                db.ADDRESSes.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }
        public ADDRESS Insert(ADDRESS obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.ADDRESSes.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(ADDRESS obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.ADDRESSes.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}

