using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerRepository : IRepository<CUSTOMER>
    {
        public CUSTOMER GetByID(string id)
        {
            using (DMEntities db = new DMEntities())
            {
                return db.CUSTOMERs.Find(int.Parse(id));
            }
        }
        public void Delete(CUSTOMER obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.CUSTOMERs.Attach(obj);
                db.CUSTOMERs.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public CUSTOMER Insert(CUSTOMER obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.CUSTOMERs.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }
        public int GetIdByIDPerson(int idPerson)
        {
            using (DMEntities db = new DMEntities())
            {
                var query = (from u in db.CUSTOMERs where u.IDPERSON == idPerson select new { u.ID }).ToList();
                return query.Count > 0 ? query[0].ID : -1;
            }
        }
        public void Update(CUSTOMER obj)
        {
            throw new NotImplementedException();
        }
    }
}
