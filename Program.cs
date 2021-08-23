/* M E T H O D S
Example for Greeting:
Name      DisplayGreeting (Pascal Case)
Input     None
Work      Print greeting to the console
Output    None

method type   output type   inputs
static        void          DisplayGreeting()
*/

using System;
namespace EmployeeDatabase
{
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
    static void Main(string[] args)
    {
      DisplayGreeting();

      Console.Write("What is your name? ");
      var name = Console.ReadLine();

      Console.Write("What is your department number? ");
      var department = int.Parse(Console.ReadLine());

      Console.Write("What is your yearly salary (in dollars)? ");
      var salary = int.Parse(Console.ReadLine());
      
      var salaryPerMonth = salary / 12;
      Console.WriteLine($"Hello, {name} you make {salaryPerMonth} a month.");
    }
} }
