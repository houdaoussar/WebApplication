using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ClientController: Controller
    {

        public IActionResult AddClient()
        {
            return View();
        }
    }
}
