using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay5
{
    class ElementalMutant : Mutant
    {

        public int Region { get; set; }

        public override int DangerQuotient()
        {
            int dq = Level * Region;
            return dq;
        }
    }
}
