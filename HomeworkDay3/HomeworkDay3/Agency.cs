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
            string info = AgencyName + " -- " + Country + " -- " + OrganizationSize;
            return info;
        }

 
    }
}
