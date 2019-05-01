using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AdminIB.Controllers
{
    public class _IBController : Controller
    {
        // 
        // GET: /IB/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /IB/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}