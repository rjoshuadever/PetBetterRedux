using PetBetterRedux.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetBetterRedux.Controllers
{
    public class HomeController : Controller
    {
        private MasterListSingleton _service;

        public HomeController()
        {
            _service = MasterListSingleton.Instance;//Fetch the Instance from the MasterListSingleton
        }

        public ActionResult Index()
        {
            IndexViewModel IndexVm = new IndexViewModel();
            IndexVm.AnimalList = _service.fetchAllAnimals();

            //IndexVm.Message = "All Animals";

            return View(IndexVm);
        }

        public ActionResult ViewDogs()
        {
            DogViewModel DogVm = new DogViewModel();

            List<Animal> TempList = _service.fetchAllAnimals().Where(a => a.Type == BaseType.Dog).ToList();
            List<Dog> DogList = TempList.Cast<Dog>().ToList();
            DogVm.DogList = DogList;

            return View(DogVm);
        }

        public ActionResult ViewCats()
        {
            CatViewModel CatVm = new CatViewModel();

            List<Animal> TempList = _service.fetchAllAnimals().Where(a => a.Type == BaseType.Cat).ToList();
            List<Cat> CatList = TempList.Cast<Cat>().ToList();
            CatVm.CatList = CatList;
            

            return View(CatVm);
        }

        public ActionResult ViewBirds()
        {
            BirdViewModel BirdVm = new BirdViewModel();

            List<Animal> TempList = _service.fetchAllAnimals().Where(a => a.Type == BaseType.Bird).ToList();
            List<Bird> BirdList = TempList.Cast<Bird>().ToList();
            BirdVm.BirdList = BirdList;

            return View(BirdVm);
        }

        public ActionResult ViewOthers()
        {
            OtherViewModel OtherVm = new OtherViewModel();

            List<Animal> TempList = _service.fetchAllAnimals().Where(a => a.Type == BaseType.Other).ToList();
            List<Other> OtherList = TempList.Cast<Other>().ToList();
            OtherVm.OtherList = OtherList;

            return View(OtherVm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        

        public ActionResult OfferPet()
        {


            return View();
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

            return View(NewDog);
        }
        //End-Create

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




        public IEnumerable<Dog> DogList { get; set; }
    }
}