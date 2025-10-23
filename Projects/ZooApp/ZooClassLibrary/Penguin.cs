using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZooClassLibrary
{
    public class Penguin:Animal
    {

        public Penguin(string name="PINGU", string colour="Red", int age = 1, int limbCount = 4, double quiffLength= 10.0  ): base( name, colour, age, limbCount)
        {
            this.QuiffLength = quiffLength;
        }
        public double QuiffLength { get; set; }

        public string Waddle(string direction, int wobbleQuotient)
        {
            return $"{Name} is waddling {direction} with a wobble quotient of {wobbleQuotient}.";
        }

        public override string Eat(string food)
        {
            return $"{Name} the penguin swimming and gulping at the {food}.";
        }

        override public string ToString()
        {
            return $"Penguin:{base.ToString()}, QuiffLength: {QuiffLength})";
        }
    }
}
