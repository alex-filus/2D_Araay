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
            int rows = 0;
            int columns = 0;

            Console.WriteLine("Welcome! \nWhat modes would you like to run?\nPress \"1\" for symbols or \"2\" for number.");
            string modeChoice = Console.ReadLine();

            while (modeChoice != "1" && modeChoice != "2")
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
               


                if (modeChoice == "1")
                {

                    Console.WriteLine("What symbol you'd like to use: hearts or faces?");
                    Console.WriteLine("1. Hearts");
                    Console.WriteLine("2. Faces");
                    string choice = Console.ReadLine();
                    string symbol = "";

                    while (symbol == "")
                    {
                        if (choice.ToLower() == "hearts")
                        {
                            symbol = HEARTS;
                        }

                        if (choice.ToLower() == "faces")
                        {
                            symbol = FACES;
                        }
                        else
                        {
                            Console.WriteLine(@"Invalid. Please enter ""hearts"" or ""faces"".");
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



                if (modeChoice == "2")
                {

                for (int j = 0; j < columns; j++)
                {
                    Console.Write("X----", Color.Green);
                    
                }
                Console.Write("X", Color.Green);
                Console.Write("\n");

                for (int i = 0; i < rows; i++)

                {

                    for (int j = 0; j < columns; j++)
                    {
                        

                            Console.Write("| " + " 1 ", Color.Red);
                    

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
