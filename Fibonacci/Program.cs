namespace Fibonacci;

/*
    Created by tuannguyencs
    Problem - Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number.
    Solution - User is prompted to enter an integer of how many times they want a fibonacci sequence to increment. 
               Program declares an array of size input and keeps track of incrementing numbers this way.
*/

public class Program
{
    static void Main(string[] args)
    {
        // Declaring variables
        int inputNumber = 0;

        // Input number must be more than 2 because n1 and n2 are hard coded
        while (inputNumber < 3)
        {
            Console.WriteLine("Enter an amount of times (more than 2) you would like a fibonacci sequence to increment.");

            try
            {
                inputNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Not a valid number.\n{ex.Message}\n");
                continue;
            }

            inputNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        // Hard coded first two numbers because they can't pull from previous values
        var fib = new int[inputNumber];
        fib[1] = 1;
        Console.Write($"Fibonacci sequence: {fib[0]}, {fib[1]}, ");

        // Accessing previous values using an array
        for (int i = 2; i < fib.Length; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];

            if (i == fib.Length - 1)
            {
                Console.Write(fib[i] + "\n");
            }
            else
            {
                Console.Write(fib[i] + ", ");
            }
        }
    }
}