using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooClassLibrary
{
    public class TRex:Animal
    {
        public TRex(string name = "Rexy", string colour = "Green", int age = 5, int limbCount = 2, double jawStrength = 1000.0) : base(name, colour, age, limbCount)
        {
            this.JawStrength = jawStrength;
        }
        public double JawStrength { get; set; }
        public string Roar(int volumeLevel)
        {
            return $"{Name} lets out a roar at volume level {volumeLevel + 1}!";
        }
    }
    
    
}
