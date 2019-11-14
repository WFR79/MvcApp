using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class UserController : Controller
    {
        private MyDbContext _context;
        // GET: User
        public UserController()
        {
            _context = new MyDbContext();
        }
        public ActionResult Index()
        {
            var users = _context.Users;
            return View(users);
            return View();
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            try
            {;
                user.RoleId = 1;
                var customerCreated = _context.Users.Add(user);
                var response = _context.SaveChanges();
                return RedirectToAction("Index", "Home"); ;
            }
            catch (Exception ex) { throw ex; }

        }
    }
}
