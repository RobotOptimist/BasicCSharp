using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            Agency agency = new Agency();
            Spy spy = new Spy();

            agency.AgencyName = "Secrets";
            agency.Country = "India";
            agency.OrganizationSize = 10;

            spy.Agency = agency;

            spy.CodeName = "Viper";
            spy.DateLastSeen = DateTime.Parse("12/12/2009");
            spy.Notes = "Extremely Dangerous";

            spy.DisplaySpyInfo();
            
            Console.ReadLine();
        }
    }
}
