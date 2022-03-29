using AayushisBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AayushisBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<ICategoryRepository>
    {
        void Update(CategoryRepository category);
    }
}
