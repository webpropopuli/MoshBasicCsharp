using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;

            Console.WriteLine("Mosh Examples");

            do {
                menu = ShowMenu();

                switch (menu)
                {
                    case 0:
                        break;

                    case 1:
                        CarSpeed();
                        break;

                    case 3:
                        DivBy3();
                        break;

                    case 4:
                        ThreeSmallest();
                        break;
    
                    default:
                        continue;
                }
            }
            while (menu != 0);

            int ShowMenu()
                {
                var x = 0;
                Console.WriteLine("Menu...");
                Console.WriteLine(" --Chapter 5");
                Console.WriteLine("1. Speed Cam");
                Console.WriteLine("3. Div by Three");
                Console.WriteLine(" --Chapter 6");
                Console.WriteLine("4. 3 Smallest");
                Console.WriteLine("0. Exit");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("<Menu rv={0}>\n", x);
                return x;
                }
        }

        // #1
        public static void CarSpeed()
        {
            Console.WriteLine("\n***Speed Limit*");
            Console.WriteLine("Enter speed limit");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter car speed");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed > speedLimit)
            {
                int points = 0;
                while (carSpeed > speedLimit)
                {
                    carSpeed -= 5;
                    points++;
                }

                if (points > 12)
                    Console.WriteLine("Too many points, we're yanking your license.");
            }
            else
            {
                Console.WriteLine("Speed OK");
            }
        }

        //#3
        private static void DivBy3()
        {
            Console.WriteLine("***DivBy3*");
            var count = 0;
            for (var i = 1; i <= 100; i++)
                if (i % 3 == 0) count++;

            Console.WriteLine("DivBy3 says '{0}'",  count);
        }

        //#4
        private static void ThreeSmallest()
            {
                Console.WriteLine("Enter list of nums separated by commas: ");
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    Console.WriteLine("The list cannot be empty or null");
                else
                {
                    var numbers = GetNums(input);
                    numbers.Sort();
                    if (numbers.Count < 5)
                        Console.WriteLine("Invalid list, has less than 5 numbers. Please retry.");
                    else
                    {
                        var smallest3 = new List<int>();
                        for (var i = 0; i < 3; i++)
                            smallest3.Add(numbers[i]);

                        smallest3.ForEach(Console.WriteLine);  //display nums
                    }
                }

            List<int> GetNums(string str)
            {
                List<int> l = str.Split((',')).Select(s => Convert.ToInt32(s.Trim())).ToList();
                return l;

            }
        }
    }
}
