using AayushisBooks.DataAccess.Repository.IRepository;
using AayushisBooks.Models;
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
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);

            SetSP_Call(new SP_Call(_db));
        }
        public DataAccess.Repository.IRepository.ICategoryRepository Category { get; private set; }
        public CoverTypeRepository CoverType { get; }
        public ProductRepository Product { get; }

        private static void SetSP_Call(ISP_Call value)
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value));
            }
        }

        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save()
        {
            _db.SaveChanges();
        }
   
 }

    internal class Set
    {
    }

    public class Get
    {
    }
}
