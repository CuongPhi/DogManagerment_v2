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
        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public ACCOUNT Insert(ACCOUNT obj)
        {
            throw new NotImplementedException();
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
                               PASSWORD="",
                               PASSWORD2=""                               
                            }).ToList();
            }
        }
    }
}
