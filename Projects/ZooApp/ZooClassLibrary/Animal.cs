namespace ZooClassLibrary
{
    public class Animal
    {
        private int limbcount = 4;

        //public Animal()
        //{
           
        //}
      
        public Animal(string name="Anon", string colour="Brown", int age=1, int limbcount=4)
        {
            this.name = name;
            this.colour = colour;
            this.Age = age;
            this.limbcount = limbcount;
        }

        private List<string> validColours = new List<string>()
        {
            "Brown",
            "Black",
            "White",
            "Grey",
            "Yellow",
            "Pink",
            "Green",
            "Blue",
            "Red",
            "Orange"
        };

        private string colour;

        public string Colour
        {
            get { return colour; }
            set {
                if (!validColours.Contains(value))
                {
                    value = "Brown";
                }
                colour = value; 
            }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { 
                while (value.Length < 2)
                {
                    value = value + "*";
                }
                name = value; 
            }
        }


        public int Age { get; set; } = 1;

        public int LimbCount
        {
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                this.limbcount = value;
            }

            get
            {
                return this.limbcount;
            }
        }

        //public void SetLimbCount(int value)
        //{
        //    if (value < 0)
        //    {
        //        value = 0;
        //    }

        //    this.limbcount = value;
        //}

        //public int GetLimbCount()
        //{
        //    return limbcount;
        //}

        public string Speak()
        {
            return "Roar!";
        }

        public string Eat(string food)
        {
            return $"{name} is eating {food}.";
        }

        public string Move(string direction)
        {
            return $"{name} is moving {direction}.";
        }

        override public string ToString()
        {
            return $"Animal(Name: {name}, Colour: {colour}, Age: {Age}, LimbCount: {limbcount})";
        }
    }
}