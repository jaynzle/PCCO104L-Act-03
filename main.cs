using System;

class Program {
  public static void Main (string[] args) {
    string input;
    string previousInput = "";

    do
    {
      Console.WriteLine("Enter something: ");
      input = Console.ReadLine();
      Console.WriteLine(previousInput + " " + input);
      previousInput += " " + input;
    }
    while (input != "exit");

    Console.WriteLine("Program closed.");
  }
}
