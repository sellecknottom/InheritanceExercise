using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile:Animal
    {
        public Reptile() 
        { 
        }
        public bool HasFeathers { get; set; }
        public bool IsExtinct { get; set; }
        public int NumberOfLegs { get; set; }
        public bool IsCarnivore { get; set; }
    }
}
