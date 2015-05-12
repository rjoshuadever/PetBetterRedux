using PetBetterRedux.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetBetterRedux.Controllers
{
    public class DogController : Controller
    {

        private MasterListSingleton _service;

        public DogController()
        {
            _service = MasterListSingleton.Instance;//Fetch the Instance from the MasterListSingleton
        }
        //Create Dog Starts here
        [HttpGet]
        public ActionResult OfferDog()
        {

            var NewDog = new Dog();
            return View(NewDog);
        }

        [HttpPost]
        public ActionResult OfferDog(Dog NewDog)
        {
            _service.AddDogOffer(NewDog);

           return Redirect("/Home/ViewDogs");
            
        }
        //End-Create
    }
}