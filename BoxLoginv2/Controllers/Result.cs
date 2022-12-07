using BoxLoginv2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoxLoginv2.Controllers
{
    public class Result : Controller
    {
        public ActionResult index()
        {
            return View("Login");
        }
    }
}
