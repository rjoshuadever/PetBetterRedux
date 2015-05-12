using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetBetterRedux.Models
{
    public class Other:Animal
    {
        public Other()
        {
            this.Type = BaseType.Other;
        }

        public string SpecialNeeds { get; set; }
    }
}