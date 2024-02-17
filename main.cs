using System;

class Program {
  public static void Main (string[] args) {
    string input;

    do
    {
      Console.WriteLine("Enter something: ");
      input = Console.ReadLine();
      Console.WriteLine(input);
    }
    while (input != "exit");

    Console.WriteLine("Program closed.");
    }
}