using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityGenerator
{
    class MinorTraitsGenerator
    {
        List<string> positiveTraits = new List<string>();
        List<string> neutralTraits = new List<string>();
        List<string> negativeTraits = new List<string>();

        Random random = new Random();

        // Get three random positve traits from the list in the positive traits file
        public void generatePositiveTraits()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\Users\Erik\Programs\C#\NPCGenerator\MinorPositiveTraitsList.txt");
            for(int i = 0; i < 3; i++)
            {
                int index = random.Next(1, lines.Length);

                // Skip [0], used to identify traits
                positiveTraits.Add(lines[index]);

                // Remove trait so there is no doubles
                var traits = new List<string>(lines);
                traits.RemoveAt(index);
                lines = traits.ToArray();
            }
        }

        // Get three random neutral traits from the list in the nuetral traits file
        public void generateNeutralTraits()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\Users\Erik\Programs\C#\NPCGenerator\MinorNeutralTraitsList.txt");
            for (int i = 0; i < 3; i++)
            {
                int index = random.Next(1, lines.Length);

                // Skip [0], used to identify traits
                neutralTraits.Add(lines[index]);

                // Remove trait so there is no doubles
                var traits = new List<string>(lines);
                traits.RemoveAt(index);
                lines = traits.ToArray();
            }
        }

        // Get three random negative triats traits from the list in the negative traits file
        public void generateNegativeTraits()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\Users\Erik\Programs\C#\NPCGenerator\MinorNegativeTraitsList.txt");
            for (int i = 0; i < 3; i++)
            {
                int index = random.Next(1, lines.Length);

                // Skip [0], used to identify traits
                negativeTraits.Add(lines[index]);

                // Remove trait so there is no doubles
                var traits = new List<string>(lines);
                traits.RemoveAt(index);
                lines = traits.ToArray();
            }
        }

        //Print all generated traits, and say if no traits were generated for each type
        public void printGeneratedMinorTraits()
        {
            if (positiveTraits.Count > 0)
            {
                Console.WriteLine("\r\nMinor Positive Traits:");
                foreach(string trait in positiveTraits)
                {
                    Console.WriteLine(trait);
                }
            }
            else
            {
                Console.WriteLine("No positive traits generated");
            }
            if (neutralTraits.Count > 0)
            {
                Console.WriteLine("\r\nMinor Nuetral Traits:");
                foreach (string trait in neutralTraits)
                {
                    Console.WriteLine(trait);
                }
            }
            else
            {
                Console.WriteLine("No nuetral traits generated");
            }
            if (negativeTraits.Count > 0)
            {
                Console.WriteLine("\r\nMinor Negative Traits:");
                foreach (string trait in negativeTraits)
                {
                    Console.WriteLine(trait);
                }
            }
            else
            {
                Console.WriteLine("No negative traits generated");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
