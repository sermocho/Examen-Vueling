using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas.Services.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task Insert(List<T> item);
        Task All_Delete();
        Task<IEnumerable<T>> FindAll();
        
    }
}
