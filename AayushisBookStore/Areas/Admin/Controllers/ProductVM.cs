using AayushisBooks.Models;

namespace DipensBookStore.Areas.Admin.Controllers
{
    internal class ProductVM : Product
    {
        public Product Product { get; set; }
        public object CategoryList { get; set; }
        public object CoverTypeList { get; set; }
    }
}