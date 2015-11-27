using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolDAL.Repository
{
    public interface IRepository<T>
    {
        List<T> ReadAll();
        void Add(T t);
        void Delete(int id);
        void Update(T t);
        T Find(int id);

    }
}
