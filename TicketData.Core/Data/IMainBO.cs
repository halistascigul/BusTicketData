using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TicketData.Core.Data
{
    public interface IMainBO<T>
    {
        T Get(int id);
        List<T> GetList();
        bool Insert(T model);
        bool Update(T model);
        bool Delete(int id);
    }
}
