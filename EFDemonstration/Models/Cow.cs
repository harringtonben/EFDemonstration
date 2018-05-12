using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDemonstration.Models
{
    public class Cow
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }
        public CowType Type { get; set; }

    }

    public enum CowType
    {
        Dairy,
        Wild,
        Chocolate,
        Sacrifical
    }
}