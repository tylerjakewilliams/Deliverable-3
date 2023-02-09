/*
 * Author: Tyler Williams
 * Date: 1/31/23
 * Description: Reads a number between 1 and 100 from the user, and displays either the even numbers or odd numbers
 * between 1 and the given number
 */

using System;

namespace Deliverable_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";

            try
            {
                while (true)
                {
                    Console.Write("Enter an integer number between 1 and 100: ");
                    input = int.Parse(Console.ReadLine());

                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Specify the series type: Even or Odd ");
                    series = Console.ReadLine();

                    if (series == "Even" || series == "Odd" || series == "even" || series == "odd")
                    {
                        break;
                    }
                }

                if (series == "Odd" || series == "odd")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 1; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (series == "Even" || series == "even")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 0; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Please type either 'Even' or 'Odd'");
            }
        }
    }
}