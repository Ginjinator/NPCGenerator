using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class HumanNameGenerator : NameGenerator
    {
        public HumanNameGenerator(){}

        public override string GenerateMaleName()
        {
            List<string> namesList = new List<string> { "Bob", "Jerry", "Matt", ""};
            int listLength = namesList.Count;
            Random random = new Random();

            var name1 = random.Next(0, listLength);
            var name2 = random.Next(0, listLength);
            Console.WriteLine("Name one: " + namesList[name1]);
            Console.WriteLine("Name two: " + namesList[name2]);

            return namesList[name1];
        }

        public override string GenerateFemaleName()
        {
            var femaleName = "Violet";
            Console.WriteLine("Name: " + femaleName);

            return femaleName;
        }
    }
}
