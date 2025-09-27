using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaGD.Data;

namespace PruebaGD.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ApplicationDbContext _dbContext; 

            public CategoriaController(ApplicationDbContext dbContext)
            {
                _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
