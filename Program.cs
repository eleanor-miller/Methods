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
      DisplayGreeting();

      var name = PromptForString("What is your name? ");

      var department = PromptForInteger("What is your department number? ");

      var salary = PromptForInteger("What is your yearly salary (in dollars)? ");

      var salaryPerMonth = salary / 12.0;
      Console.WriteLine($"Hello, {name} you make {salaryPerMonth} a month.");
    }
} }
