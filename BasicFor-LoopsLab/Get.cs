using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFor_LoopsLab
{
    internal class Get
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

    }
}
