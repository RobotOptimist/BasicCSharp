using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            Asset asset = new Asset();

            asset.CodeName = "Viper";
            asset.Region = "USA";
            asset.SkillSet = "Bombs";

            Personell personell = new Personell();
            
            personell.CodeName = "Viper";
            personell.Region = "USA";
            personell.SkillSet = "Bombs";
            personell.Department = "Explosives";
            personell.Supervisor = "Robert";

            Agent agent = new Agent();

            agent.CodeName = "Viper";
            agent.Region = "USA";
            agent.SkillSet = "Bombs";

            Analyzer.Analyze(asset);
            Analyzer.Analyze(personell);
            Analyzer.Analyze(agent);

            Console.ReadLine();

        }
    }
}
