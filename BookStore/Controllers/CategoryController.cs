using BookStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BookStoreDbContext dbContext;
        public CategoryController(BookStoreDbContext db) 
        { 
            this.dbContext = db;
        }

        public IActionResult Index()
        {
            var objCategoryList = dbContext.Categories.ToList();

            return View();
        }
    }
}
