using B2ATech.Learn.OOP;
using B2ATech.Learn.OOP.Inheritance;

Console.WriteLine("Weclome to OOPs Deonstration : Inheritance!");

//Inheritance is one of the fundamental attributes of object-oriented programming.
//It allows you to define a child class that reuses(inherits), extends, or modifies
//the behavior of a parent class. The class whose members are inherited is called the base class.
//The class that inherits the members of the base class is called the derived class.

//We have created Shape as base class, also an abstract base class
//The abstract modifier indicates the incomplete implementation. 
//we can never create/construct an instance of abstract class
//Below line will result in an error

//Shape shape = new Shape();

//However we can delcare an abstract class object and create using one of the child class
ConsoleHelper.PrintSectionHeader("1. Circle is a derived class of shape!");

Shape circle = new Circle(5);

Console.WriteLine($"{circle}: area, {Shape.GetArea(circle)}; " +
                     $"perimeter, {Shape.GetPerimeter(circle)}");


ConsoleHelper.PrintSectionHeader("2. Rectangle is a derived class of shape!");

Shape rectangle = new Rectangle(5,10);

Console.WriteLine($"{rectangle}: area, {Shape.GetArea(rectangle)}; " +
                     $"perimeter, {Shape.GetPerimeter(rectangle)}");

//However if we have additional implementation and of those methods or properties are not there in the base class
//We can cast the child class as below
Rectangle rect = rectangle as Rectangle;

Console.WriteLine($"Is Square: {rect.IsSquare()}, Diagonal: {rect.Diagonal}");


ConsoleHelper.PrintSectionHeader("3. Square is a derived class of shape!");

Shape square = new Square(5);

Console.WriteLine($"{square}: area, {Shape.GetArea(square)}; " +
                     $"perimeter, {Shape.GetPerimeter(square)}");

//However if we have additional implementation and of those methods or properties are not there in the base class
//We can cast the child class as below
Square sq = square as Square;
Console.WriteLine($"Diagonal: {sq.Diagonal}");