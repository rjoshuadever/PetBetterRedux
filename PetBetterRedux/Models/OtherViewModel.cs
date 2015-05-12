using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetBetterRedux.Models
{
    public class OtherViewModel
    {
        public string Message { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public BaseType Type { get; set; }
        public string SubType { get; set; }
        public string Description { get; set; }

        public string SpecialNeeds { get; set; }

        public List<Other> OtherList { get; set; }
    }
}