using ZooClassLibrary;

Animal animal = new Animal("Bonzo", "Yellow", 3, 3);
//animal.name = "Bonzo";
//animal.colour = "Yellow";
//animal.Age = 3;
//animal.limbcount = 3;

Animal anotherAnimal = new Animal();
anotherAnimal.Name = "Fifi";
anotherAnimal.Colour = "Pink";
anotherAnimal.Age = 4;
anotherAnimal.LimbCount = -1;
Console.WriteLine(anotherAnimal.LimbCount);

Animal wonkyAnimal = new Animal();
wonkyAnimal.Name = "F";
wonkyAnimal.Colour = "Spotty";
wonkyAnimal.Age = 4;
wonkyAnimal.LimbCount = -1;

string message = animal.Eat("bananas");
string message2 = anotherAnimal.Eat("chocolate");

Console.WriteLine(message);
Console.WriteLine(message2);
Console.WriteLine(animal.ToString());
Console.WriteLine(anotherAnimal.ToString());
Console.WriteLine(wonkyAnimal.ToString());

List<Animal> animals = new List<Animal>(){
  animal,
  anotherAnimal,
  wonkyAnimal,
  new Animal("George", "Green", 2, 4),
  new Animal("Sally", "Blue", 5, 4), new Animal("Rex", "Red", 7, 4)
};

animals.Add(new Animal("Tiny", "Orange", 1, 4));

foreach (Animal a in animals) {
  Console.WriteLine(a.Eat("Mintos"));
  Console.WriteLine(a.Wobble);
}