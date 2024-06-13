using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public Animal() //default constructor
        {

        } 
        public bool Grows { get; set; } = true;
        public bool Motile { get; set; } = true ;
        public string FoodType { get; set; }
        public bool Organs { get; set; } = true;
    }
}
