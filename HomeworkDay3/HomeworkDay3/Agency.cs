using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay3
{
    class Agency
    {
        public string AgencyName { get; set; }
        public string Country { get; set; }
        public int OrganizationSize { get; set; }

        public string GetAgencyInfo() 
        {
            string info = "{0} -- {1} -- {2}", AgencyName, Country, OrganizationSize;
            return info;
        }

 
    }
}
