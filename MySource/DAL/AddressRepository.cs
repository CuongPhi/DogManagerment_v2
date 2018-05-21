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
            throw new NotImplementedException();
        }
    }
}

