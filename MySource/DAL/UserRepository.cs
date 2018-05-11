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
        public List< Object> GetAll()
        {
             
            using (DMEntities db = new DMEntities())
            {
                var query = (from user in db.USERAPPs
                            join infor in db.PERSONINFORs on user.IDPERSON equals infor.ID
                            join acc in db.ACCOUNTs on user.ID equals acc.ID_USER
                            select new { user.ID,  user.IDPERSON,user.SALARY, user.DAYJOIN, user.ID_BANK, user.ID_MEDICAL,
                                infor.NAME, infor.gender,  infor.EMAIL,infor.BIRHDAY, infor.PHONE,
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
    }
}
