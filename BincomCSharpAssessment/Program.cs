
using System;

class Program
{
    static void Main(string[] args)
    {
        // Task 1: Declare variables and display their values.
        string name = "John Doe";
        int age = 25;
        bool isAdmin = true;

        Console.WriteLine("TASK 1: Variables");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Is Admin: {isAdmin}");

        // Task 2: Check whether an entered number is even or odd.
        Console.WriteLine("\nTASK 2: Even or Odd");
        Console.Write("Enter an integer: ");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }

        // Task 3: Display numbers from 1 to 10.
        Console.WriteLine("\nTASK 3: For Loop");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Task 4: Calculate the sum and display array elements.
        Console.WriteLine("\nTASK 4: Arrays");

        int[] numbers = { 2, 4, 6, 8, 10 };
        int sum = 0;

        foreach (int item in numbers)
        {
            sum += item;
        }

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine("Array elements:");

        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }

        // Task 5: Call a method that displays a greeting.
        Console.WriteLine("\nTASK 5: Greeting Method");
        Greet("Alice");
    }

    // Accepts a name and displays a personalised greeting.
    static void Greet(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}
