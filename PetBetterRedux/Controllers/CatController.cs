using PetBetterRedux.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetBetterRedux.Controllers
{
    public class CatController : Controller
    {

        private MasterListSingleton _service;

        public CatController()
        {
            _service = MasterListSingleton.Instance;//Fetch the Instance from the MasterListSingleton
        }
        // GET: Cat
        public ActionResult OfferCat()
        {
            var NewCat = new Cat();
            return View(NewCat);
        }

        [HttpPost]
        public ActionResult OfferCat(Cat NewCat)
        {
            _service.AddCatOffer(NewCat);
            
            return View(NewCat);
        }
        //End-Create

            
    }
}