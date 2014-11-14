using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay5
{
    class Program
    {
        static void Main(string[] args)
        {
            PsychicMutant thought = new PsychicMutant();
            PsychicMutant memory = new PsychicMutant();

            PhysicalMutant pounder = new PhysicalMutant();
            PhysicalMutant crusher = new PhysicalMutant();

            ElementalMutant fizzle = new ElementalMutant();
            ElementalMutant freeze = new ElementalMutant();

            List<IDisplayable> mutants = new List<IDisplayable>();

            mutants.Add(thought);
            mutants.Add(memory);
            mutants.Add(crusher);
            mutants.Add(pounder);
            mutants.Add(fizzle);
            mutants.Add(freeze);

            thought.CodeName = "Thought";
            thought.Level = 5;
            thought.IQ = 150;
            thought.UsageCount = 240;            

            memory.CodeName = "Memory";
            memory.Level = 6;
            memory.IQ = 160;
            memory.UsageCount = 205;
            
            pounder.CodeName = "Pounder";
            pounder.Level = 2;
            pounder.Strength = 50;
            pounder.IQ = 110;

            crusher.CodeName = "Crusher";
            crusher.Level = 10;
            crusher.Strength = 100;
            crusher.IQ = 80;

            fizzle.CodeName = "Fizzle";
            fizzle.Level = 8;
            fizzle.Region = 200;

            freeze.CodeName = "Freeze";
            freeze.Level = 25;
            freeze.Region = 1000;

            foreach (Mutant mutant in mutants)
            {
                mutant.DisplayInfo();
            }

            Console.ReadLine();


        }
    }
}
