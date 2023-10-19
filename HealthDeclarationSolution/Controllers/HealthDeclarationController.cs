
using HealthDeclarationSolution.Data;
using HealthDeclarationSolution.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthDeclarationSolution.Controllers
{
    public class HealthDeclarationController : Controller
    {
        private readonly ApplicationDBContext _dbcontext;
        public HealthDeclarationController(ApplicationDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<HealthDeclarationViewModel> objHealthDeclaration = _dbcontext.HealthDeclarations;
            return View(objHealthDeclaration);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HealthDeclarationViewModel model)
        {
            _dbcontext.HealthDeclarations.Add(model);
            _dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
