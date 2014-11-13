using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay4
{
    class Personell : Asset
    {
        private string department;
        private string supervisor;

        public string Department { get; set; }
        public string Supervisor { get; set; }

        public Personell()
        {            
            Department = "";
            Supervisor = "";
        }
    }
}
