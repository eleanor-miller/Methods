/* M E T H O D S
Example for Greeting:
Name      DisplayGreeting (Pascal Case)
Input     None
Work      Print greeting to the console
Output    None

method type   output type   method name / input
static        void          DisplayGreeting()
*/

using System;
using System.Collections.Generic;

namespace Methods
{
  // class keyword, name of class (PascalCase)
  class Employee
  {
    // public means "this can be seen outside of the class" public/private most used
    // type (cannot use var because we need to declare what it is)
    // name of property (label)
    public string Name;
    public int Department;
    public int Salary;
    public int MonthlySalary;

    // This is a *special* method known as a "constructor"
    // The constructor is called when we write a line like: `var bob = new Employee(`
    //                                                       bob = object of type list

    // The arguments to the method should line up to those below

    public Employee(string newName, int newDepartment, int newSalary, int newMonthlySalary)
    {
      // In the constructor we should setup the values for any of the properties.
      // Here we will *copy* the values give by the arguments to the corresponding property. 

      Name = newName;
      Department = newDepartment;
      Salary = newSalary;
      MonthlySalary = newMonthlySalary;
    }
  }
  class Program
  {
    static void DisplayGreeting()
    {
      Console.WriteLine("--------------------------------");
      Console.WriteLine("Welcome to Our Employee Database");
      Console.WriteLine("--------------------------------");
      Console.WriteLine();
      Console.WriteLine();
    }

    static string PromptForString(string prompt)
    {
      Console.WriteLine("🐙🐙🐙");
      // Use the argument, whatever the caller sent us.
      Console.Write(prompt);

      // Get some user input
      var userInput = Console.ReadLine();

      // RETURN that value as the output of this method. 
      // The value in 'userInput' will go wherever the 
      // *CALLER* of the method has specified.
      return userInput;
    }

    static int PromptForInteger(string prompt)
    {
      var userInput = PromptForString(prompt);

      int inputAsInteger;
      var isThisGoodInput = int.TryParse(userInput, out inputAsInteger);

      if (isThisGoodInput)
      {
        return inputAsInteger;
      }
      else
      {
        Console.WriteLine("That isn't a valid number. Please try again.");
        return 0;
      }

    }

    static void Main(string[] args)
    {
      // graceHopper is an object instance of class Employee
      var graceHopper = new Employee("Grace Hopper", 100, 240_000, 24_000);
      Console.WriteLine(graceHopper.Department);

      var elonMusk = new Employee("Elon Musk", 42, 120_000, 10_000);
      Console.WriteLine(elonMusk.Department);

      var employees = new List<Employee>();
      employees.Add(graceHopper);
      employees.Add(elonMusk);

      employees.RemoveAt(0);

      DisplayGreeting();

      var name = PromptForString("What is your name? ");

      var department = PromptForInteger("What is your department number? ");

      var salary = PromptForInteger("What is your yearly salary (in dollars)? ");

      var salaryPerMonth = salary / 12.0;
      Console.WriteLine($"Hello, {name} you make {salaryPerMonth} a month.");
    }
} }
