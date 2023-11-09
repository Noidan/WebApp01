using Microsoft.AspNetCore.Mvc;
using WebApp01.Models;

namespace WebApp01.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Contact contact)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");     
            }

            return View("Index");
        }
    }
}
