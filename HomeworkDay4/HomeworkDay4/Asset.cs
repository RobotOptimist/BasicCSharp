using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay4
{
    class Asset
    {
        private string codeName;
        private string region;
        private string skillSet;

        public string CodeName { get; set; }
        public string Region { get; set; }
        public string SkillSet { get; set; }

        public Asset()
        {
            CodeName = "";
            Region = "";
            SkillSet = "";
        }

        public virtual void Print()
        {
            Console.WriteLine("{0} - {1} - {2}", CodeName, Region, SkillSet);
        }
    }
}
