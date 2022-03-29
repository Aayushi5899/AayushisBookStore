using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AayushisBooks.DataAccess.Repository.IRepository
{
    interface UnitOfWork
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }
    }
}
