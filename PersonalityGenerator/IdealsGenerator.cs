using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityGenerator
{
    class IdealsGenerator
    {
        List<string> idealsList = new List<string>();

        Random random = new Random();

        public void generateIdeals()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\Users\Erik\Programs\C#\NPCGenerator\IdealsList.txt");
            for (int i = 0; i < 3; i++)
            {
                // Skip [0], used to identify
                int index = random.Next(1, lines.Length);

                idealsList.Add(lines[index]);

                var ideals = new List<string>(lines);
                ideals.RemoveAt(index);
                lines = ideals.ToArray();
            }
        }

        public void printIdeals()
        {
            Console.WriteLine("\r\nIdeals:");
            foreach(string ideal in idealsList)
            {
                Console.WriteLine(ideal);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
