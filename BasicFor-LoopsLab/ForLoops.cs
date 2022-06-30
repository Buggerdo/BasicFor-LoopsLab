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
                Console.WriteLine(Tools.Total(number));
            } while(Tools.IsYes());
        }


    }
}
