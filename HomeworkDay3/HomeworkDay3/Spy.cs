using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay3
{
    class Spy
    {
        public string CodeName;
        public Agency Agency;
        public DateTime DateLastSeen;
        public string Notes;

        public void DisplaySpyInfo()
        {
            Console.WriteLine(CodeName + "--" + DateLastSeen
                + "--" + Notes);
            Console.WriteLine(Agency.GetAgencyInfo());
        }
    }
}
