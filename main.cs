using System;

class Program {
  public static void Main (string[] args) {
    string input;
    string previousInput = "";

    do
    {
      Console.WriteLine("Enter something: ");
      input = Console.ReadLine();

      if (previousInput != "")
        Console.WriteLine(previousInput + " " + input);
      else
        Console.WriteLine(input);

      previousInput += input;
    }
    while (input != "exit");

    Console.WriteLine("Program closed.");
  }
}
