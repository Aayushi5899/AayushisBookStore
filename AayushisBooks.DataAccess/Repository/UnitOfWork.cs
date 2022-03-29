using AayushisBooks.DataAccess.Repository.IRepository;
using AayushisBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AayushisBooks.DataAccess.Repository
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }
        public DataAccess.Repository.IRepository.ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call(_get; private set;)

            public void Dispose()
        {
            _db.Dispose();
        }
        public void Save()
        {
            _db.SaveChanges();
        }
   
 }

    internal class set
    {
    }

    public class _get
    {
    }
}
