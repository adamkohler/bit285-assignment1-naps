using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bit285_assignment1_naps.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bit285_assignment1_naps.Controllers
{
    public class NapsController : Controller
{
        // GET: /<controller>/
        [HttpGet]
        public IActionResult AccountInfo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AccountInfo(User user)
        {
            /*string lname = user.LastName;
            string fname = user.FirstName;
            string mail = user.EmailAdd;
            string program = user.Program;
            return RedirectToAction("Password_info", lname, fname, mail, program); */
            //Playing around with different ideas for passing user information between calls
            return RedirectToAction("Password_Info", user);

        }



        [HttpGet]
        public IActionResult Password_info(bit285_assignment1_naps.Models.User user)
        {
            return View(user);
        }
        [HttpPost]
        public IActionResult Password_info(User user, string boo)
        {
            return RedirectToAction("Select_password", user);
        }



        [HttpGet]
        public IActionResult Select_password(User user)
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Select_password()
        {
            return RedirectToAction("Confirm_account");
        }



        [HttpGet]
        public IActionResult Confirm_account()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Confirm_account(User u)
        {
            return RedirectToAction("Login");
        }



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }



    }
}
