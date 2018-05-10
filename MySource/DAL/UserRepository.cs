using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class UserRepository : IUserRepository
    {
        public List<USERAPP> GetAll()
        {
            using (DMEntities db = new DMEntities())
            {
                return db.USERAPPs.ToList();
            }
        }
        public USERAPP Insert(USERAPP obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.USERAPPs.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }
    }
}
