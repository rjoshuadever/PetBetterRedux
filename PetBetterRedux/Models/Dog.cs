using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetBetterRedux.Models
{
    public class Dog:Animal
    {
        public Dog() {
            this.Type = BaseType.Dog;
        }

        public bool isHouseTrained { get; set; }
    }
}