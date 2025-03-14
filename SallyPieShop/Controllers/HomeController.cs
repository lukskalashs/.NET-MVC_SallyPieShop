using Microsoft.AspNetCore.Mvc;
using SallyPieShop.Data;

namespace SallyPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;
        public HomeController(IPieRepository pieRepository) 
        { 
            _pieRepository = pieRepository;
        
        }
        public IActionResult Index()
        {
            return View(_pieRepository.AllPies);
        }

        public IActionResult Details(int id)
        {
           var pie = _pieRepository.GetPieById(id);
            if(pie == null)
            {
                return NotFound();
            }
            return View(pie);
        }
    }
}
