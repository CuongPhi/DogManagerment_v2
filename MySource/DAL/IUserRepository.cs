using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public interface IRepository<T>
    {
        List< Object> GetAll();
        T Insert(T obj);
    }
}
