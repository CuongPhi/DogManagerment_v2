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
            using (DMEntities db= new DMEntities())
            {
                var query = (from infor in db.PERSONINFORs
                             join add in db.ADDRESSes on infor.ID_TT equals add.IDPERSON
                             join cus in db.CUSTOMERs on infor.ID equals cus.IDPERSON
                             select new
                             {
                                 infor.ID,
                                 infor.ID_TT,
                                 infor.NAME,
                                 GENDER = infor.gender,
                                 infor.EMAIL,
                                 infor.BIRHDAY,
                                 infor.PHONE,
                                 ADDRESS = add.STREET + " P." + add.WARD + " Q." + add.DISTRICT,
                                 add.WARD,
                                 add.DISTRICT,
                                 add.STREET                             
                             });
                return query.ToList().Cast<Object>().ToList();
            }
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
            using (DMEntities db = new DMEntities())
            {
                db.CUSTOMERs.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
