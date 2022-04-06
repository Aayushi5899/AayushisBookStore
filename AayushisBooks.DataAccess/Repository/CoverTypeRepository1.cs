using AayushisBookStore.DataAccess.Data;

namespace AayushisBooks.DataAccess.Repository
{
    internal class CoverTypeRepository
    {
        private ApplicationDbContext db;

        public CoverTypeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
    }
}