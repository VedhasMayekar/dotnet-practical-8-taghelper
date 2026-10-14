using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using pract8.Models;

namespace pract8.Controllers
{
    public class EmpController : Controller
    {
        private static readonly List<EmployeeModel> EmpList = new List<EmployeeModel>();

        public IActionResult Index()
        {
            return View(EmpList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new EmployeeModel();
            model.Countries = GetCountries();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                EmpList.Add(model);
                return RedirectToAction(nameof(Success));
            }

            model.Countries = GetCountries();
            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }

        private static List<SelectListItem> GetCountries()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Text = "India", Value = "IND" },
                new SelectListItem { Text = "Canada", Value = "CND" },
                new SelectListItem { Text = "Japan", Value = "JPN" }
            };
        }
    }
}