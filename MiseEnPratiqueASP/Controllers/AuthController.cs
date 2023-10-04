using Microsoft.AspNetCore.Mvc;

using MiseEnPratiqueASP.Db_Connection;
using MiseEnPratiqueASP.Models;

using System.Data.SqlClient;

namespace MiseEnPratiqueASP.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Register");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(ModelValidationRegisterForm form)
        {
            if(ModelState.IsValid)
            {
                ConnectionSQL.AddUser(form);
                return RedirectToAction("Index","Home");
            }
                return View(form);
        }
    }
}
