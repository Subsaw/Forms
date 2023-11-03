using Forms.Models;
using Microsoft.AspNetCore.Mvc;

namespace Forms.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Form input)
        {
            if (ModelState.IsValid)
            {
                if (input.City is not null)
                    input.City = Enum.GetName(typeof(Form.Cities), int.Parse(input.City));
                return View("Results", input);
            }
            else
                return View();
        }
        public IActionResult Results(Form input)
        {
            return View(input);
        }
    }
}
