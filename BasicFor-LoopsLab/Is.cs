using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFor_LoopsLab
{
    internal class Is
    {
        /// <summary>
        /// Askes user if they would like to continue player
        /// </summary>
        /// <returns>Bool true or false</returns>
        public static bool IsAgain()
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
    }
}
