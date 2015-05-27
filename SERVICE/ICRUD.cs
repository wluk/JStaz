using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES
{
    public interface ICRUD<T>
    {
        void Create(T obj);
        List<T> SelectAll();
        T SelectById(int id);
        void Update(T obj);
        void Delete(int id);
    }
}
