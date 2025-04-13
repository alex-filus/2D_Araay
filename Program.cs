using System;
using System.Drawing;
using Console = Colorful.Console;

namespace _2D_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[1, 1];

            Console.WriteLine("How many rows do you want to enter?");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many columns do you want to enter?");
            int columns = Convert.ToInt32(Console.ReadLine());

            grid = new int[rows, columns];

            //for (int i = 0; i < rows; i++)
            //{   
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write("\u2665"+ " ", Color.Red);
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i < rows; i++)

            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j % 2 != 0)
                        {                            

                                Console.Write("\u2665" + " ", Color.Red);
                        }
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
