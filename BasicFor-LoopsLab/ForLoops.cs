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
                Console.WriteLine(Tools.Total(Get.GetInt(1)));
            } while(Is.IsAgain());
        }
    }
}
