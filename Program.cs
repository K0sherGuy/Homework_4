using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your result:");
            char Input = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (Input)
            {
                case 'A':
                    Console.WriteLine("Outstanding!");
                    break;

                case 'B':
                    Console.WriteLine("Superior!");
                    break;

                case 'C':
                    Console.WriteLine("Good!");
                    break;

                case 'D':
                    Console.WriteLine("Satisfactory!");
                    break;

                case 'E':
                    Console.WriteLine("Low Pass!");
                    break;

                case 'F':
                    Console.WriteLine("Failure!");
                    break;

                default:
                    Console.WriteLine("Result is invalid!");
                    break;
            }
        }
    }
}
