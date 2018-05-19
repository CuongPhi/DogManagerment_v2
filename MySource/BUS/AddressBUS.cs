﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AddressBUS
    {
        static IRepository<ADDRESS> reps;
        static AddressBUS()
        {
            reps = new AddressRepository();
        }
        public static void Update(ADDRESS obj)
        {
            reps.Update(obj);
        }
        public static List<Object> GetAll()
        {
            return reps.GetAll();
        }
        public static ADDRESS Insert(ADDRESS obj)
        {
            return reps.Insert(obj);
        }
        public static ADDRESS GetByID(string id)
        {
           return  reps.GetByID(id);
        }
    }
}
