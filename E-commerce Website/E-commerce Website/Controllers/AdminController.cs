﻿using E_commerce_Website.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace E_commerce_Website.Controllers
{
    public class AdminController : Controller
    {
        private myContext _context;
        public AdminController(myContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            string admin_session = HttpContext.Session.GetString("admin_session");
            if (admin_session != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("login");
            }
        }

        public IActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Login(string adminEmail, string adminPassword)
        {
             var row = _context.tbl_admin.FirstOrDefault(a => a.admin_email == adminEmail);
            if(row != null && row.admin_password == adminPassword)
            {
                
                HttpContext.Session.SetString("admin_session", row.admin_id.ToString());
                return RedirectToAction("Index");

            }
            else
            {
                ViewBag.message = "Incorrect Username or Password";
                return View();
            }
         

        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("admin_session");

            return RedirectToAction("login");

        }
    }
  }
