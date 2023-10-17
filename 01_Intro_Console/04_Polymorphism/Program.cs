
using _04_Polymorphism;



Animal myAnimal = new Animal();  // Create a Animal object
Animal myPig = new Pig();  // Create a Pig object
Animal myDog = new Dog();  // Create a Dog object

myAnimal.animalSound();
myPig.animalSound();
myDog.animalSound();

var shapes = new List<Shape>
{
    new Rectangle(),
    new Triangle(),
    new Circle()
};

// Polymorphism at work #2: the virtual method Draw is
// invoked on each of the derived classes, not the base class.
foreach (var shape in shapes)
{
    shape.Draw();
}