using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week5CodeChallenge.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        [HttpGet]
        public ActionResult Index()
        {
      
            Models.Week5CodeChallenge cf = new Models.Week5CodeChallenge();
            return View(cf);
        }

   
       
    [HttpPost]
        public ActionResult Index(Models.Week5CodeChallenge cf)
        {
            //establish a connection to the database
            var db = new Models.SimoneEntities();
            //add contact form to database
            db.Week5CodeChallenge.Add(cf);
            db.SaveChanges();
            return RedirectToAction("ThankYou");
        }
        //Get Contact thank you
        public ActionResult ThankYou() {

            return View();
        
        }
    }
}
