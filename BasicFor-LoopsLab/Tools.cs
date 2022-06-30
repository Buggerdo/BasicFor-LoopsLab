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
