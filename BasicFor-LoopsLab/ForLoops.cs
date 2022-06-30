using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFor_LoopsLab
{
    internal class ForLoops
    {
        public ForLoops()
        {
            do
            {
                int number = Tools.GetInt(1);
                Console.WriteLine(Total(number));
            } while(Tools.IsYes());
        }

        private static int Total(int x)
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
