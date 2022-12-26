// See https://aka.ms/new-console-template for more information
using B2ATech.Learn.OOP;
using B2ATech.Learn.OOP.Constrctors;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

Console.WriteLine("Weclome to OOPs Deonstration!");
Console.WriteLine();

//ConsoleHelper is class and PrintSectionHeader is a static method that does not require object creation
ConsoleHelper.PrintSectionHeader("1. Object creation with default constructor!");

//Declaration
Person personDefaultConstrctor = null;

//Constrction
personDefaultConstrctor = new Person();
personDefaultConstrctor.ShowDetails();

ConsoleHelper.PrintSectionHeader("2. Object creation with one parameter constructor!");
//Declaration
Person personOneParamConstrctor = null;

//Constrction
personOneParamConstrctor = new Person(100);
personOneParamConstrctor.ShowDetails();


ConsoleHelper.PrintSectionHeader("3. Object creation with two parameter constructor!");
//Declaration
Person personTwoParamConstrctor = null;

//Constrction
personTwoParamConstrctor = new Person(100,"Rayaba");
personTwoParamConstrctor.ShowDetails();

ConsoleHelper.PrintSectionHeader("4. Object creation with three parameter constructor!");
//Declaration
Person personThreeParamConstrctor = null;

//Constrction
personThreeParamConstrctor = new Person(100, "Rayaba",99);
personThreeParamConstrctor.ShowDetails();

ConsoleHelper.PrintSectionHeader("4. Object Declaration/creation readonly property!");

//Declaration & Constrction at the same time plus read only property
Person personReadOnly =
personReadOnly = new Person(100, "Rayaba", 99);
Console.WriteLine("Name is readonly! Name : " + personReadOnly.Name);
//Below line will result in error
//personReadOnly.Name = "Rayaba Changed";




