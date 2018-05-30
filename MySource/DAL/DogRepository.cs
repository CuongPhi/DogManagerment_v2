using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class DogRepository : IRepository<DOG>
    {
        public DOG GetByID(string id)
        {
            using (DMEntities db = new DMEntities())
            {
                return db.DOGs.Find(int.Parse(id));
            }
        }
        public void Delete(DOG obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.DOGs.Attach(obj);
                db.DOGs.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<object> GetAll()
        {
            using (DMEntities db = new DMEntities())
            {
                var query = (from dog in db.DOGs
                             join infor in db.DOG_INFOR on dog.ID equals infor.IDDOG
                             join type in db.DOGTYPEs on dog.TYPE equals type.ID_TYPE
                             join house in db.DOGHOUSEs on dog.IDDOGHOUSE equals house.ID
                             where dog.STATUS == 0
                             select new 
                             {
                                 ID_DOG = dog.ID, dog.WEIGHT, FOOD_PRICE = dog.FOODPRICE, dog.DAYIN, dog.IMAGES,
                                 type.NAME_TYPE, type.ID_TYPE,
                                 house.DESTRIPTION, ID_HOUSE = house.ID,
                                 DOG_ADDRESS = infor.STREET +" " + infor.WARD +" "+ infor.DISTRICT, infor.TIME,
                                 NumOfDay = DbFunctions.DiffDays(dog.DAYIN, DateTime.Now),
          
                             });
                return query.ToList().Cast<Object>().ToList();
            }
        }
        public List<object> Search(string key)
        {
            if (key == "") return GetAll();
            using (DMEntities db = new DMEntities())
            {
                var query = (from dog in db.DOGs
                             join infor in db.DOG_INFOR on dog.ID equals infor.IDDOG
                             join type in db.DOGTYPEs on dog.TYPE equals type.ID_TYPE
                             join house in db.DOGHOUSEs on dog.IDDOGHOUSE equals house.ID
                             where dog.DETROYED == false && dog.STATUS == 0 &&
                             (
                             infor.WARD.Contains(key) || infor.DISTRICT.Contains(key) ||
                             infor.STREET.Contains(key) || dog.DAYIN.ToString().Equals(key)
                             )
                             select new
                             {
                                 ID_DOG = dog.ID,
                                 dog.WEIGHT,
                                 FOOD_PRICE = dog.FOODPRICE,
                                 dog.DAYIN,
                                 dog.IMAGES,
                                 type.NAME_TYPE,
                                 type.ID_TYPE,
                                 house.DESTRIPTION,
                                 ID_HOUSE = house.ID,
                                 DOG_ADDRESS = infor.STREET + " " + infor.WARD + " " + infor.DISTRICT,
                                 infor.TIME,
                                 NumOfDay = DbFunctions.DiffDays(dog.DAYIN, DateTime.Now),

                             });
                return query.ToList().Cast<Object>().ToList();
            }
        }
        public DOG Insert(DOG obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.DOGs.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(DOG obj)
        {
            using (DMEntities db = new DMEntities())
            {
                db.DOGs.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public int getID()
        {
            using (DMEntities db = new DMEntities())
            {
                return db.DOGs.Max(c => c.ID);
            }
        }
        public int getIdDog(int id)
        {
            using (DMEntities db = new DMEntities())
            {
                var query = (from dog in db.DOGs where dog.ID == id select new { dog.ID }).ToList();
                return query.Count > 0 ? query[0].ID : -1;
            }
        }
    
    }
}
