using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDemonstration.Models
{
    public class Farm
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual int Size { get; set; }
        public virtual IList<Cow> Cows { get; set; }
    }
}