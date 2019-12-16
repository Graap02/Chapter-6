using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            Console.WriteLine("Please enter a number, 1-3, to set your preffered viewing order.");
            Console.WriteLine("1 - View the array as is");
            Console.WriteLine("2- View the array in a sorted manner");
            Console.WriteLine("3- Print the array (up to the number 5) and then reverse the order");
            userChoice = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[] { 0, 3, 7, 5, 8, 4, 2, 1};
            for (int i = 0; i < array.Length; i++)
            {
                if (userChoice == 1)
                {
                    if (i < 10)
                    {
                        Console.Write(array[i] + ", ");
                    }
                    else
                    {
                        Console.WriteLine(array[i]);
                    }
                }
                else if (userChoice == 2)
                {
                    if (i < 10)
                    {
                        Array.Sort(array);
                        Console.Write(array[i] + ", ");
                    }
                    else
                    {
                        Array.Sort(array);
                        Console.WriteLine(array[i]);
                    }
                }
                else if (userChoice == 3)
                {
                    if (i < 10)
                    {
                        Array.Reverse(array);
                        Console.Write(array[i] + ", ");
                    }
                    else
                    {
                        Array.Reverse(array);
                        Console.WriteLine(array[i]);
                    }
                }

            }

        }
    }
}
