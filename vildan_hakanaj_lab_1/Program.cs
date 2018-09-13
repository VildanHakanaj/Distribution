using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vildan_hakanaj_lab_1
{
    class Program
    {
        public static Random rnd = new Random();
        public static int maxStar = 80;
        static void Main(string[] args)
        {
            Console.Write("Enter the number of loops: ");
            int numTrials = Convert.ToInt32(Console.ReadLine());
            //DisplayMenu();
            //Question1(numTrials);
            Question1(numTrials);
            Console.WriteLine("");
            Console.ReadKey();
        }
        /// <summary>
        /// Question 1
        /// 
        /// </summary>
        /// <param name="numTrials">The number of random number to generate</param>
        public static void Question1(int numTrials)
        {
            int[] bin = new int[10]; //Create a new array of bins

            for (int i = 0; i < numTrials; i++) //Loop the number of times the user hase assigned
            {
                int bin_number = rnd.Next(bin.Length); //Get the random number from 0 - 9
                ++bin[bin_number]; //Increment the bin with that number;
            }

            //PrintMethod(bin); //The printing method
            CalculateStar(numTrials, bin);
        }

        public static void Question2(int numTrials)
        {
            int[] bin = new int[12];
            
            for (int i = 0; i < numTrials; i++)
            {
                int num1 = rnd.Next(1, 7); 
                int num2 = rnd.Next(1, 7);
                int bin_number = (num1 + num2) - 2;
                ++bin[bin_number];
            }

            CalculateStar(numTrials, bin);
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("Welcome to Lab1 ==> MadeBy: Vildan Hakanaj");
            Console.WriteLine("Type the command.");
            Console.WriteLine("clear  --> Clear the screen.");
            Console.WriteLine("run    --> Run the simulation");
            Console.WriteLine("trials --> Change the number of trials");
        }

        /// <summary>
        /// Calculate and print the amount of stars need it.
        /// </summary>
        /// <param name="numTrials"></param>
        /// <param name="bin"></param>
        public static void CalculateStar(int numTrials, int[] bin)
        {
            double[] percentage = new double[bin.Length]; 
            for (int i = 0; i < bin.Length; i++)
            {
                percentage[i] = bin[i] / (double)numTrials;

                Console.Write("Bin nr_{0}: {1} ", (i + 1).ToString().PadRight(4, ' ') , bin[i]);
                int numStar = (int)(maxStar * percentage[i]);
                for (int j = 0; j < numStar; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
