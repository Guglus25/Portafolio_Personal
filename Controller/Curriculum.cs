using Microsoft.AspNetCore.Mvc;

namespace Portafolio.Controller
{
    public class Curriculum : ControllerBase
    {
        public IActionResult Index()
        {
            return RedirectToPage("Curriculum");
        }
    }
}
