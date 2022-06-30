using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFor_LoopsLab
{
    internal class Tools
    {
        /// <summary>
        /// Gets a positive int form the user
        /// </summary>
        /// <returns>Positive int</returns>
        public static int GetInt(int low)
        {
            int x;
            bool isNumber;
            do
            {
                Console.Clear();
                Console.Write("Please enter a number: ");
                if(int.TryParse(Console.ReadLine(), out x) || x > low)
                {

                    isNumber = false;
                }
                else
                {
                    Console.WriteLine("Sorry that is not a valid number");
                    Thread.Sleep(2000);
                    isNumber = true;
                }

            } while(isNumber);
            Console.Clear();
            return x;
        }

        /// <summary>
        /// Askes user if they would like to continue player
        /// </summary>
        /// <returns>Bool true or false</returns>
        public static bool IsYes()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            do
            {
                Console.Clear();
                Console.Write("Would you like to continue (Y/N)? ");
                string awnser = Console.ReadLine().ToLower().Trim();
                Console.Clear();
                if(awnser == "y" || awnser == "yes" || awnser == "yup")
                {
                    return true;
                }
                else if(awnser == "n" || awnser == "no" || awnser == "nope")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Sorry that is not a valid answer");
                    Thread.Sleep(2000);
                }
            } while(true);
        }

        /// <summary>
        /// Totals all the numbers from 0 to the user input
        /// </summary>
        /// <param name="x">User number</param>
        /// <returns>Total</returns>
        public static int Total(int x)
        {
            int total = 0;
            for(int i = 0; i <= x; i++)
            {
                total += i;
            }
            return total;
        }

    }
}
