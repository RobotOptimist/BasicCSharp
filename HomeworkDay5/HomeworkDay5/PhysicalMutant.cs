using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay5
{
    class PhysicalMutant : Mutant
    {

        public int IQ { get; set; }
        public int Strength { get; set; }

        public override int DangerQuotient()
        {
            int dq = Level * IQ * Strength;
            return dq;
        }

    }
}
