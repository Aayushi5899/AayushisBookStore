using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AayushisBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<IProductRepository>
    {
        void Update(IProductRepository product);
    }
}