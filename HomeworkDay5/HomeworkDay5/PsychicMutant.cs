using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay5
{

    class PsychicMutant : Mutant
    {

        public int IQ { get; set; }
        public int UsageCount { get; set; }


        public override int DangerQuotient()
        {
            int dq = Level * IQ * UsageCount;
            return dq;
        }
    }
}
