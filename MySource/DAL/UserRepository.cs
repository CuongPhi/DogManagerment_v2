using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class UserRepository : IRepository<USERAPP>
    {
        public  USERAPP GetByID(string id)
        {
            using (DMEntities db = new DMEntities())
            {
                return db.USERAPPs.Find(int.Parse(id));
            }
        }
        public int GetIdByIDPerson(int idPerson)
        {
            using (DMEntities db = new DMEntities())
            {
                var query = (from u in db.USERAPPs where u.IDPERSON == idPerson select new { u.ID }).ToList();
                return query.Count > 0 ? query[0].ID : -1;
            }
        }
        public void Delete(USERAPP obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.USERAPPs.Attach(obj);
                db.USERAPPs.Remove(obj);
                db.SaveChanges();
            }
        }

        public List< Object> GetAll()
        {
             
            using (DMEntities db = new DMEntities())
            {
                var query = (from user in db.USERAPPs
                            join infor in db.PERSONINFORs on user.IDPERSON equals infor.ID
                            join acc in db.ACCOUNTs on user.ID equals acc.ID_USER
                            select new { user.ID, infor.ID_TT,   user.IDPERSON,user.SALARY, user.DAYJOIN, user.ID_BANK, user.ID_MEDICAL,
                                infor.NAME,GENDER= infor.gender,  infor.EMAIL,infor.BIRHDAY, infor.PHONE,
                                acc.USERNAME
                            });
                return query.ToList().Cast<Object>().ToList();
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

        public void Update(USERAPP obj)
        {
            throw new NotImplementedException();
        }
    }
}
