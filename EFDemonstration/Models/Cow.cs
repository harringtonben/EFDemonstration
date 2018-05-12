using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDemonstration.Models
{
    public class Cow
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
        public virtual decimal Weight { get; set; }
        public virtual CowType Type { get; set; }
        public virtual Farm Farm { get; set; }
    }

    public enum CowType
    {
        Dairy,
        Wild,
        Chocolate,
        Sacrifical
    }
}