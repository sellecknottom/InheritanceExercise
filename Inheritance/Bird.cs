using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird:Animal
    {
        public Bird() 
        {
        }
        public bool Feathers { get; set; }
        public bool LaysEggs { get; set; }
        public string FeatherColor { get; set; }
        public string LandWaterAir { get; set; }
    }
}
