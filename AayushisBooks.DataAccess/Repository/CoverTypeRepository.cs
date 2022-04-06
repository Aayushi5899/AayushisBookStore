using AayushisBookStore.DataAccess.Data;
using AayushisBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AayushisBooks.DataAccess.Repository
{
    public class ICoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public ICoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public object Name { get; private set; }

        public void Update(ICoverTypeRepository covertype)
        {
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == covertype.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = covertype.Name;

            }
        }
    }

    public class CoverType
    {
    }
}