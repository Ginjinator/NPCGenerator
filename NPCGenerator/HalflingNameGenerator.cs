using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class HalflingNameGenerator : NameGenerator
    {
        List<string> maleNames = new List<string> {"Alton", "Ander", "Cade", "Corrin", "Eldon", "Errich",
            "Finnan", "Garret", "Lindal", "Lyle", "Merric", "Milo", "Osborn",
            "Perrin", "Reed", "Roscoe", "Wellby"};
        List<string> femaleNames = new List<string> {"Andry", "Bree", "Callie", "Cora", "Euphemia",
            "Jillian", "Kithri", "Lavinia", "Lidda", "Merla", "Nedda", "Paela",
            "Portia", "Seraphina", "Shaena", "Trym", "Vani", "Verna"};
        List<string> clanNames = new List<string> {"Brushgather", "Goodbarrel", "Greenbottle",
            "High-hill", "Hilltopple", "Leagallow", "Tealeaf", "Thorngage",
            "Tosscobble", "Underbough"};

        private string createdName = "";
        Random random = new Random();

        public override string GenerateMaleName()
        {
            var pickFullName = random.Next(1, 5);
            if (pickFullName == 5)
            {
                createdName = maleNames[random.Next(0, maleNames.Count - 1)];
                var clanName = " " + GenerateClanName();
                createdName += clanName;
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
                var clanName = " " + GenerateClanName();

                createdName += clanName;
                return createdName;
            }
        }

        public override string GenerateFemaleName()
        {
            var pickFullName = random.Next(1, 5);
            if (pickFullName >= 4)
            {
                createdName = femaleNames[random.Next(0, femaleNames.Count - 1)];
                var clanName = " " + GenerateClanName();
                createdName += clanName;
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
                var clanName = " " + GenerateClanName();

                createdName += clanName;
                return createdName;
            }
        }

        public string GenerateClanName()
        {
            var pickFullName = random.Next(1, 5);
            if (pickFullName == 5)
            {
                var clanName = " " + clanNames[random.Next(0, clanNames.Count - 1)];
                return clanName;
            }
            else
            {
                int halfOfName = 0;
                var name1 = clanNames[random.Next(0, clanNames.Count - 1)];
                var name2 = clanNames[random.Next(0, clanNames.Count - 1)];

                halfOfName = (name1.Length / 2);
                var firstHalf = name1.Substring(0, halfOfName);
                halfOfName = (name2.Length / 2);
                var secondHalf = name2.Substring(halfOfName);

                var clanName = firstHalf + secondHalf;
                return clanName;
            }
        }

    }
}
