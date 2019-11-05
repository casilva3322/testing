using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wellSomeTest.Models;
using System.Web;
using SaveFormData.Models;

namespace wellSomeTest.Controllers
{
    public class thisTController : Controller
    {
                // GET: Home
        public ActionResult Index()
        {
            return View();
        }
 
        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }
 
        // POST: Home/Create
        [HttpPost]
                public ActionResult Create(StudentModel smodel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ViewData["Name"] = smodel.Name;
                    ViewData["City"] = smodel.City;
                    ViewData["Address"] = smodel.Address;
 
                    return View("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
    }
}
}
