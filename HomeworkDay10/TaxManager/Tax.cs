using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxManager
{
    public static class Tax
    {
        public static double Analyzer(int num)
        {
            double rtax = (double)num * 0.075;
            return rtax;
        }
    }
}
