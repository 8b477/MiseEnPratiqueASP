using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using MiseEnPratiqueASP.Db_Connection;
using MiseEnPratiqueASP.Models;

using System.Data.SqlClient;

namespace MiseEnPratiqueASP.Controllers
{
    public class LoginController : Controller
    {
        
        public IActionResult Index()
        {
            return RedirectToAction("Connection");
        }

        public IActionResult Connection()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Connection(LoginValidation log)
        {            
            if (ModelState.IsValid)
            {      
                return RedirectToAction("Hello", "Home", new { nom = ConnectionSQL.LogUser(log)});
                
            }
            return View(log);
        }
    }
}
