using PetBetterRedux.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetBetterRedux.Controllers
{
    public class BirdController : Controller
    {

        private MasterListSingleton _service;

        public BirdController()
        {
            _service = MasterListSingleton.Instance;//Fetch the Instance from the MasterListSingleton
        }
        //Create Dog Starts here
        [HttpGet]
        public ActionResult OfferBird()
        {

            var NewBird = new Bird();
            return View(NewBird);
        }

        [HttpPost]
        public ActionResult OfferBird(Bird NewBird)
        {
            _service.AddBirdOffer(NewBird);

            return View(NewBird);
        }
        //End-Create
    }
}