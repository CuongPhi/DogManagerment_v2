using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class StatisticBillRepository
    {
        public List<SoQuy> thongKe()
        {
            using (DMEntities db = new DMEntities())
            {
                var query = (from billin in db.BILL_IN
                             join personinf in db.PERSONINFORs on billin.ID_USER equals personinf.ID
                             join dog in db.DOGs on billin.IDDOG equals dog.ID
                             select new SoQuy{ TYPE = "Chi",ID_BILL=billin.ID_BILL, DAY_BILL=(DateTime)billin.DAY_BILL, NAME = personinf.NAME, VALUE = (long)(billin.FINE + dog.FOODPRICE) })
                            .Union(from billout in db.BILL_OUT
                                   join personinf in db.PERSONINFORs on billout.ID_USER equals personinf.ID
                                   select new SoQuy{ TYPE = "Thu", ID_BILL = billout.ID_BILL, DAY_BILL = (DateTime)billout.DAY_BILL, NAME = personinf.NAME, VALUE = (long)(billout.TOTALPRICE)});

                return query.ToList();
            }
        }
        public List<SoQuy> search(string ten)
        {

            string upper = ten.ToUpper();
            string lower = ten.ToLower();
            //List<SoQuy> tim = new List<SoQuy>();
            //  tim = thongKe();
            //tim.Find(x => x.NAME.Contains(ten));
            //return tim;
            //foreach (var item in tim)
            //{

            //}
            using (DMEntities db = new DMEntities())
            {
                var query = (from billin in db.BILL_IN

                             join personinf in db.PERSONINFORs on billin.ID_USER equals personinf.ID
                             let ten_in = personinf.NAME
                             join dog in db.DOGs on billin.IDDOG equals dog.ID

                             where ten_in.StartsWith(lower)
                           || ten_in.StartsWith(upper)
                           || ten_in.Contains(ten)
                             select new SoQuy { TYPE = "Chi", ID_BILL = billin.ID_BILL, DAY_BILL = (DateTime)billin.DAY_BILL, NAME = personinf.NAME, VALUE = (long)(billin.FINE + dog.FOODPRICE) })
                           .Union(from billout in db.BILL_OUT
                                  join personinf in db.PERSONINFORs on billout.ID_USER equals personinf.ID
                                  let ten_out = personinf.NAME
                                  where ten_out.StartsWith(lower)
                           || ten_out.StartsWith(upper)
                           || ten_out.Contains(ten)
                                  select new SoQuy { TYPE = "Thu", ID_BILL = billout.ID_BILL, DAY_BILL = (DateTime)billout.DAY_BILL, NAME = personinf.NAME, VALUE = (long)(billout.TOTALPRICE) });

                return query.ToList();

            }
        }
        public List<SoQuy> trangThaiThanhToan()
        {
            using (DMEntities db = new DMEntities())
            {
               
                var query = (from bill_out in db.BILL_OUT
                             join personinf in db.PERSONINFORs on bill_out.ID_USER equals personinf.ID
                             select new SoQuy { TYPE = "Thu", ID_BILL = bill_out.ID_BILL, DAY_BILL = (DateTime)bill_out.DAY_BILL, NAME = personinf.NAME, VALUE = (long)(bill_out.TOTALPRICE) });

               
                return query.ToList();
                    
            }
                
        }
        public List<SoQuy> trangThaiDaHuy()
        {
            using (DMEntities db = new DMEntities())
            {
                var query1 = (from billin in db.BILL_IN
                              join personinf in db.PERSONINFORs on billin.ID_USER equals personinf.ID
                              join dog in db.DOGs on billin.IDDOG equals dog.ID
                              select new SoQuy { TYPE = "Chi", ID_BILL = billin.ID_BILL, DAY_BILL = (DateTime)billin.DAY_BILL, NAME = personinf.NAME, VALUE = (long)(billin.FINE + dog.FOODPRICE) })
                           .Union(from billout in db.BILL_OUT
                                  join personinf in db.PERSONINFORs on billout.ID_USER equals personinf.ID
                                  select new SoQuy { TYPE = "Thu", ID_BILL = billout.ID_BILL, DAY_BILL = (DateTime)billout.DAY_BILL, NAME = personinf.NAME, VALUE = (long)(billout.TOTALPRICE) });

                var query = (from bill_out in db.BILL_OUT
                            
                             join personinf in db.PERSONINFORs on bill_out.ID_USER equals personinf.ID
                             select new SoQuy { TYPE = "Thu", ID_BILL = bill_out.ID_BILL, DAY_BILL = (DateTime)bill_out.DAY_BILL, NAME = personinf.NAME, VALUE = (long)(bill_out.TOTALPRICE) });
                var query4 = (from bill_in in db.BILL_IN
                              join personinf in db.PERSONINFORs on bill_in.ID_USER equals personinf.ID
                              join bill_out in db.BILL_OUT on bill_in.IDDOG equals bill_out.IDDOG
                              join dog in db.DOGs on bill_in.IDDOG equals dog.ID
                              select new SoQuy { TYPE = "Chi", ID_BILL = bill_in.ID_BILL, DAY_BILL = (DateTime)bill_in.DAY_BILL, NAME = personinf.NAME, VALUE = (long)(bill_in.FINE + dog.FOODPRICE) });
                              
                var query3 = query1.Except(query);
                var query5 = query3.Except(query4);
                return query5.ToList();

            }

        }
        public List<SoQuy> LoaiPhieuThu(DateTime start, DateTime end)
        {
            using (DMEntities db = new DMEntities())
            {
                var query=(from bill_out in db.BILL_OUT
                           join personinf in db.PERSONINFORs on bill_out.ID_USER equals personinf.ID
                           where (DateTime)(bill_out.DAY_BILL) >= start && (DateTime)(bill_out.DAY_BILL) <= end
                           select new SoQuy { TYPE = "Thu", ID_BILL = bill_out.ID_BILL, DAY_BILL = (DateTime)bill_out.DAY_BILL, NAME = personinf.NAME, VALUE = (long)(bill_out.TOTALPRICE) });
                return query.ToList();
            }
        }
        public List<SoQuy> LoaiPhieuChi(DateTime start, DateTime end)
        {
            using (DMEntities db = new DMEntities())
            {
                var query= (from bill_in in db.BILL_IN
                            join personinf in db.PERSONINFORs on bill_in.ID_USER equals personinf.ID
                            join dog in db.DOGs on bill_in.IDDOG equals dog.ID
                            where (DateTime)(bill_in.DAY_BILL) >= start && (DateTime)(bill_in.DAY_BILL) <= end
                          
                            select new SoQuy { TYPE = "Thu", ID_BILL = bill_in.ID_BILL, DAY_BILL = (DateTime)bill_in.DAY_BILL, NAME = personinf.NAME, VALUE = (long)(bill_in.FINE + dog.FOODPRICE) });
                return query.ToList();
                            
            }
        }
        
    }
}
