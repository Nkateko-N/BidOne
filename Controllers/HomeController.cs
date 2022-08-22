using BidOne.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace BidOne.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(PersonModel person)
        {
            string name = person.name;
            string surname = person.surname;
            if (ModelState.IsValid)
            {
               System.IO.File.WriteAllText(@"C:\Users\john\Desktop\BidOne\BidOne\Models", JsonConvert.SerializeObject(person));
              
            }
                return View(person);
        }

             
    }
}