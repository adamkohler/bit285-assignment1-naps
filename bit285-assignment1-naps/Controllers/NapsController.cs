using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bit285_assignment1_naps.Controllers
{
    public class NapsController : Controller
{
    // GET: /<controller>/
    
    public IActionResult Index()
    {

        return View();
    }

    [HttpGet]
    public IActionResult AccountInfo()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AccountInfo(Models.User user)
    {
        if (ModelState.IsValid)
            {
                
                return View("thanks");
            }
        else 
            return View();

    }
}
}
