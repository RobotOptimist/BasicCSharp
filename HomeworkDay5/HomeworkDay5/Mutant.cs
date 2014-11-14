using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay5
{
    abstract class Mutant : IDisplayable
    {
        public string CodeName { get; set; }
        public int Level { get; set; }


        public abstract int DangerQuotient();

        public virtual void DisplayInfo()
        {
            int dq = DangerQuotient();
            Console.WriteLine("DQ: {0}", dq);
        }
    }
}
