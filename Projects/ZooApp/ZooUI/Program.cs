using ZooClassLibrary;

//int animalsCount = 0;

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




List<Animal> animals = new List<Animal>()
{
    animal,
    anotherAnimal,
    wonkyAnimal,
    new Animal("George", "Green", 2, 4),
    new Animal("Sally", "Blue", 5, 4),
    new Animal("Rex", "Red", 7, 4)
};

animals.Add(new Animal("Tiny", "Orange", 1, 4));

Animal ani8 = new Animal()
{
    Name = "Max",
    Colour = "Black",
    Age = 6,
    LimbCount = 4
};

Penguin pingu = new Penguin();
animals.Add(pingu);
pingu.Name = "Pingu";
pingu.Colour = "Black and White";
pingu.QuiffLength = 12.5;

Console.WriteLine(pingu.Waddle("South", 6));

Penguin pongu = new Penguin(name:"Pongu", age: 2, limbCount:4, quiffLength: 9.3);
animals.Add(pongu);
Console.WriteLine(pongu.Eat("fish"));

TRex rexy = new TRex(name:"Rexy", colour:"Green", age:10, limbCount:2, jawStrength:1500.0);
animals.Add(rexy);

foreach (Animal a in animals)
{
    Console.WriteLine(a.Eat("Mintos"));
    Console.WriteLine(a);
    if (a is Penguin)
    {
        Penguin pen = (Penguin)a;
        Console.WriteLine($"{a.Name} has a quiff length of {pen.QuiffLength} cm.");
    }
    TRex t = a as TRex;
    if (t != null)
    {
        Console.WriteLine(t.Roar(10));
    }
}

Console.WriteLine($"There are currently {Animal.Count}");


