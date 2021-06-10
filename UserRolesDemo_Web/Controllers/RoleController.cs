using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserRolesDemo_Web.Models;

namespace UserRolesDemo_Web.Controllers
{
    public class RoleController : Controller
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Role
        public ActionResult Index()
        {
            ViewBag.Roles = _db.Roles.ToList();

            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Role model)
        {
            var role = new IdentityRole
            {
                //Id = Guid.NewGuid().ToString(),
                Name = model.Name
            };

            _db.Roles.Add(role);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}