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
                ImageUrl = "https://th.bing.com/th/id/OIP.CgFI7XLpQvHO917BUxEcXwHaFj?pid=ImgDet&rs=1",
                Id = 1,
                Name = "Bobby",
                Age = 2,
                Type = BaseType.Bird,
                SubType = "Parrot",
                Description = "Saved from a zoo, which is now closed.",
                Diet = "Seeds & Fruits"
            },

            new Cat(){
                ImageUrl = "https://th.bing.com/th/id/OIP.J1qwjJXmUcU3Wi3NfTg_ywHaHa?w=188&h=188&c=7&r=0&o=5&pid=1.7",
                Id = 2,
                Name = "Calypso",
                Age = 1,
                Type = BaseType.Cat,
                SubType = "Calico",
                Description = "Abandoned at Walmart. Beautiful Calico coat",
                DeClawed = false
            },

            new Dog(){
                ImageUrl = "https://th.bing.com/th/id/OIP.RO6aWDFWVZaNXu5vpBoKagHaD0?w=289&h=180&c=7&r=0&o=5&pid=1.7",
                Id = 3,
                Name = "Flash",
                Age = 5,
                Type = BaseType.Dog,
                SubType = "Scottish Terrier",
                Description = "Found scavenging a junkyard. Brought back to full health. Must have been abandonded by former owner as he is house trained, and responds to 'sit' commands.",
                isHouseTrained = true
            },

            new Other(){
                ImageUrl = "https://th.bing.com/th/id/OIP.qNVYjg7qrzFsgq9oaK0NdAHaFj?w=256&h=192&c=7&r=0&o=5&pid=1.7",
                Id = 4,
                Name = "Alabaster",
                Age = 1,
                Type = BaseType.Other,
                SubType = "Snake",
                Description = "Picked up by Park Rangers at local playground.",
                SpecialNeeds = "Eats rodents. Should not be near small children"
            },

            new Other(){
                ImageUrl = "data:image/jpeg;base64,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",
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