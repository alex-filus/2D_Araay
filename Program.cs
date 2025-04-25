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
            int width = 0;
            const string HEARTS = "\u2665";
            const string FACES = "\u263A";
            const string SYMBOLS_MODE = "1";
            const string NUMBERS_MODE = "2";
            const string SYMBOL_CHOICE_HEARTS = "hearts";
            const string SYMBOL_CHOICE_FACES = "faces";
            const string INVALID_MESSAGE = @"Invalid. Please enter ""hearts"" or ""faces"".";
            int startingNumber = 1;
            int rows = 0;
            int columns = 0;


            Console.WriteLine("Welcome! \nWhat modes would you like to run?\nPress \"1\" for symbols or \"2\" for number.");
            string modeChoice = Console.ReadLine();

            while (modeChoice != SYMBOLS_MODE && modeChoice != NUMBERS_MODE)
            {
                Console.WriteLine("Incorrect input. Please try again.");
                modeChoice = Console.ReadLine();
            }

            Console.WriteLine("How many rows do you want to enter?");
            rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many columns do you want to enter?");
            columns = Convert.ToInt32(Console.ReadLine());

            grid = new int[rows, columns];


            width = 2 * columns + 1;
            string border = new string('*', width);



            if (modeChoice == SYMBOLS_MODE)
            {

                Console.WriteLine("What symbol you'd like to use: hearts or faces?");
                Console.WriteLine("1. Hearts");
                Console.WriteLine("2. Faces");
                string choice = Console.ReadLine();
                string symbol = "";

                while (symbol == "")
                {
                    if (choice.ToLower() == SYMBOL_CHOICE_HEARTS)
                    {
                        symbol = HEARTS;
                    }

                    if (choice.ToLower() == SYMBOL_CHOICE_FACES)
                    {
                        symbol = FACES;
                    }
                    else
                    {
                        Console.WriteLine(INVALID_MESSAGE);
                        choice = Console.ReadLine();

                    }

                }

                Console.WriteLine(border, Color.Gold);

                for (int i = 0; i < rows; i++)

                {

                    for (int j = 0; j < columns; j++)
                    {
                        if (j % 2 != 0)
                        {

                            Console.Write("*" + symbol, Color.Red);


                        }
                        else
                        {

                            Console.Write("*" + symbol, Color.Gold);

                        }

                    }
                    Console.WriteLine("*", Color.Gold);

                }
                Console.WriteLine(border, Color.Gold);


            }



            if (modeChoice == NUMBERS_MODE)
            {

                for (int j = 0; j < columns; j++)
                {
                    Console.Write("X----", Color.Green);


                }
                Console.Write("X", Color.Green);
                Console.Write("\n");

                for (int i = 0; i < rows; i++)
                {
                    if (i > 0)
                    {


                        for (int j = 0; j < columns; j++)
                        {
                            Console.Write(" ----", Color.Red);

                        }
                        Console.WriteLine();
                    }



                    for (int j = 0; j < columns; j++)
                    {
                        string formattedNumber = $"{startingNumber,3}";
                        Console.Write("|" + formattedNumber + " ", Color.Red);
                        startingNumber++;


                    }

                    Console.WriteLine("|", Color.Red);


                }

                for (int j = 0; j < columns; j++)
                {

                    Console.Write("X----", Color.Green);

                }
                Console.Write("X", Color.Green);






            }


        }








    }
}
