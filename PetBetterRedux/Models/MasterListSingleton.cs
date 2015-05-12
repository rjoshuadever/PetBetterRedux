using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetBetterRedux.Models
{
    //Singleton to contain Mock Data for Display
    public class MasterListSingleton
    {
        private List<Animal> _allAnimals;

        private static MasterListSingleton _instance = null;

        public static MasterListSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MasterListSingleton();
                }
                return _instance;
            }
        }

        private MasterListSingleton()
        {

            _allAnimals = new List<Animal>(){
            new Bird(){
                ImageUrl = "http://www.petsfoto.com/wp-content/uploads/2010/04/Macaws2.jpg",
                Id = 1,
                Name = "Bobby",
                Age = 2,
                Type = BaseType.Bird,
                SubType = "Parrot",
                Description = "Saved from a zoo, which is now closed.",
                Diet = "Seeds & Fruits"
            },

            new Cat(){
                ImageUrl = "http://playconquest.com/wp-content/uploads/2014/07/calico-cat-wallpapers-windows8theme-h24clefm.jpg",
                Id = 2,
                Name = "Calypso",
                Age = 1,
                Type = BaseType.Cat,
                SubType = "Calico",
                Description = "Abandoned at Walmart. Beautiful Calico coat",
                DeClawed = false
            },

            new Dog(){
                ImageUrl = "http://animalepetshop.com.br/blog/wp-content/uploads/2014/06/scottish.jpg",
                Id = 3,
                Name = "Flash",
                Age = 5,
                Type = BaseType.Dog,
                SubType = "Scottish Terrier",
                Description = "Found scavenging a junkyard. Brought back to full health. Must have been abandonded by former owner as he is house trained, and responds to 'sit' commands.",
                isHouseTrained = true
            },

            new Other(){
                ImageUrl = "http://dawsonbausman.com/Pets/Snakes/large-female-columbian-boa.jpg",
                Id = 4,
                Name = "Alabaster",
                Age = 1,
                Type = BaseType.Other,
                SubType = "Snake",
                Description = "Picked up by Park Rangers at local playground.",
                SpecialNeeds = "Eats rodents. Should not be near small children"
            },

            new Other(){
                ImageUrl = "http://www.grit.com/~/media/Images/GRT/Editorial/Articles/Magazine%20Articles/2012/02-01/Raising%20Rabbits%20as%20Pets/Lop-Eared-Pet-Rabbit.jpg",
                Id = 5,
                Name = "Callie",
                Age = 1,
                Type = BaseType.Other,
                SubType = "Rabbit",
                Description = "Nearly killed in a vehicular accident. Now restored to full health, but still has limp.",
                SpecialNeeds = "Limp requires special attention while playing."
            }

        };//end _allAnimals List

        }//end MasterListSingleton Constructor

        public List<Animal> fetchAllAnimals()
        {
            return _allAnimals;
        }

        //CRUD Methods
        //Dog
        public void AddDogOffer(Dog OfferDog)
        {
            _allAnimals.Add(OfferDog);

        }
        //Cat
        public void AddCatOffer(Cat NewCat)
        {
            _allAnimals.Add(NewCat);
        }
        //Bird
        public void AddBirdOffer(Bird NewBird)
        {
            _allAnimals.Add(NewBird);
        }
        //Other
        public void AddOtherOffer(Other NewOther)
        {
            _allAnimals.Add(NewOther);
        }





       
    }
}