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