using PetBetterRedux.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetBetterRedux.Controllers
{
    public class OtherController : Controller
    {

        private MasterListSingleton _service;

        public OtherController()
        {
            _service = MasterListSingleton.Instance;//Fetch the Instance from the MasterListSingleton
        }
        //Create Dog Starts here
        [HttpGet]
        public ActionResult OfferOther()
        {

            var NewOther = new Other();
            return View(NewOther);
        }

        [HttpPost]
        public ActionResult OfferOther(Other NewOther)
        {

            //NewOther.Type = BaseType.Other;
            _service.AddOtherOffer(NewOther);

            return Redirect("/Home/ViewOthers");
        }
        //End-Create
    }
}