using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class TieflingNameGenerator : NameGenerator
    {
        List<string> maleNames = new List<string> {"Baggi", "Emen", "Engong", "Kansif",
                                                    "Myev", "Neega", "Ovak", "Ownka", "Shautha", "Sutha", "Vola",
                                                    "Volen", "Yevelda"};

        List<string> femaleNames = new List<string> {"Akta", "Anakis", "Bryseis", "Criella",
                                                    "Damaia", "Ea", "Kallista", "Lerissa", "Makaria", "Nemeia",
                                                    "Orianna", "Phelaia", "Rieta"};
        private string createdName = "";
        Random random = new Random();

        public override string GenerateMaleName()
        {
            var pickFullName = random.Next(1, 5);
            if (pickFullName >= 4)
            {
                createdName = maleNames[random.Next(0, maleNames.Count - 1)];
                return createdName;
            }
            else
            {
                int halfOfName = 0;
                var name1 = maleNames[random.Next(0, maleNames.Count - 1)];
                var name2 = maleNames[random.Next(0, maleNames.Count - 1)];

                halfOfName = (name1.Length / 2);
                var firstHalf = name1.Substring(0, halfOfName);
                halfOfName = (name2.Length / 2);
                var secondHalf = name2.Substring(halfOfName);

                createdName = firstHalf + secondHalf;
                return createdName;
            }
        }

        public override string GenerateFemaleName()
        {
            var pickFullName = random.Next(1, 5);
            if (pickFullName >= 4)
            {
                createdName = femaleNames[random.Next(0, femaleNames.Count - 1)];
                return createdName;
            }
            else
            {
                int halfOfName = 0;
                var name1 = femaleNames[random.Next(0, femaleNames.Count - 1)];
                var name2 = femaleNames[random.Next(0, femaleNames.Count - 1)];

                halfOfName = (name1.Length / 2);
                var firstHalf = name1.Substring(0, halfOfName);
                halfOfName = (name2.Length / 2);
                var secondHalf = name2.Substring(halfOfName);

                createdName = firstHalf + secondHalf;
                return createdName;
            }
        }
    }
}
