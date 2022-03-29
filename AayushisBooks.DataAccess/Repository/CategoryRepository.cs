using AayushisBooks.DataAccess.Repository.IRepository;
using AayushisBookStore.DataAccess.Data;
using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AayushisBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Add(ICategoryRepository entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ICategoryRepository> GetAll(Expression<Func<ICategoryRepository, bool>> filter = null, Func<IQueryable<ICategoryRepository>, IOrderedQueryable<ICategoryRepository>> oderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public ICategoryRepository GetFirstOrDefault(Expression<Func<ICategoryRepository, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(ICategoryRepository entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<ICategoryRepository> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if(objFromDb != null) //save changes if not null
            {
                objFromDb.Name = category> Name;
                int v = _db.SaveChanges();
            }
        }

        public void Update(CategoryRepository category)
        {
            throw new NotImplementedException();
        }

        ICategoryRepository IRepository<ICategoryRepository>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
