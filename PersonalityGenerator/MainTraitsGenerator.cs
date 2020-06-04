using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityGenerator
{
    class MainTraitsGenerator
    {
        List<string> mainTraits = new List<string> {"Openness", "Conscientiousness", "Extraversion", "Agreeablness", "Neuroticism" };
        List<string> traitsWithValues = new List<string>();

        Random random = new Random();

        string trait = "";
        int traitValue = 0;

        public string generateOpenness()
        {
            trait = mainTraits[0];
            traitValue = random.Next(1, 10);

            return trait + " " + traitValue;
        }

        public string generateConscientiousness()
        {
            trait = mainTraits[1];
            traitValue = random.Next(1, 10);

            return trait +" " + traitValue;
        }

        public string generateExtraversion()
        {
            trait = mainTraits[2];
            traitValue = random.Next(1, 10);

            return trait + " " + traitValue;
        }

        public string generateAgreeablness()
        {
            trait = mainTraits[3];
            traitValue = random.Next(1, 10);

            return trait + " " + traitValue;
        }

        public string generateNeuroticism()
        {
            trait = mainTraits[4];
            traitValue = random.Next(1, 10);

            return trait + " " + traitValue;
        }

        public void generateMainTraits()
        {
            foreach(string trait in mainTraits)
            {
                traitValue = random.Next(1, 10);

                string traitWithValue = trait + " " + traitValue;
                traitsWithValues.Add(traitWithValue);
            }
        }

        public void printMainTraitsWithValues()
        {
            Console.WriteLine("Main Traits (1 to 10):");
            foreach(string trait in traitsWithValues)
            {
                Console.WriteLine(trait);
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
