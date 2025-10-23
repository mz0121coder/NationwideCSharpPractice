using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooClassLibrary;

namespace ZooUnitTests
{
    [TestClass]
    public class AnimalTests
    {
        private Animal animal;


        [TestInitialize]
        public void setup()
        {
            animal = new Animal(name: "Bonzo", age: 42);
        }        

        [TestMethod]
        public void CreateAnimalNoArgsCtorTest()
        {
            Animal specialAnimal = new Animal();
            Assert.AreEqual("Anon", specialAnimal.Name);
            Assert.AreEqual("Brown", specialAnimal.Colour);
            Assert.AreEqual(1, specialAnimal.Age);
        }

        

        [TestMethod]
        public void ChangeNameMonzoTest()
        {
            animal.Name = "Monzo";
            Assert.AreEqual("Monzo", animal.Name);
        }

        [TestMethod]
        public void ChangeNameEmptyTest()
        {
            animal.Name = "";
            Assert.AreEqual("**", animal.Name);
        }

        [TestMethod]
        [DataRow("A", "A*")]
        [DataRow("B", "B*")]
        [DataRow("c", "c*")]
        [DataRow("", "**")]
        [DataRow("AB", "AB")]
        [DataRow("abcdefghijklmnop", "abcde")]
        public void ChangeNameSingleCharacterTest(string name, string expected)
        {
            animal.Name = name;
            Assert.AreEqual(expected, animal.Name);
        }

        [TestMethod]
        public void CreateAnimalBonzo42Test()
        {
            Assert.AreEqual("Bonzo", animal.Name);
            Assert.AreEqual(42, animal.Age);
        }


        [TestMethod]
        public void AnimalEatTest()
        {      

            string food = "Watermellon";
            string name = "Bonzo";
            
            string expected = $"{name} is eating {food}.";

            string resultOfEat = animal.Eat(food); // <--- This is the thing under test

            Assert.AreEqual(expected, resultOfEat);
            
        }

        [TestMethod]
        public void AnimalSpeakTest()
        {
            string noise = animal.Speak();
            Assert.AreEqual("Roar!", noise);
        }
    }
}
