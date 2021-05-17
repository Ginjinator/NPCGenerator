using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class DwarvenNameGenerator : NameGenerator
    {
        List<string> maleNames = new List<string> {"Alberich", "Baern", "Barendd", "Brottor",
                                                    "Bruenor", "Dain", "Darrak", "Delg", "Eberk", "Einkil", "Fargrim",
                                                    "Flint", "Gardain", "Harbek", "Kildrak", "Morgran", "Orsik",
                                                    "Oskar", "Rangrim", "Rurik", "Taklinn", "Thoradin", "Thorin",
                                                    "Tordek", "Traubon", "Travok", "Ulfgar", "Veit", "Vondal"};

        List<string> femaleNames = new List<string> {"Amber", "Artin", "Audhild", "Bardryn",
                                                    "Dagnal", "Diesa", "Eldeth", "Falkrunn", "Finellen", "Gunnloda",
                                                    "Gurdis", "Helja", "Hlin", "Kathra", "Kristryd", "Ilde", "Liftrasa",
                                                    "Mardred", "Riswynn", "Sannl", "Torbera", "Torgga", "Vistra"};

        List<string> clanNames = new List<string> {"Balderk", "Battlehammer", "Brawnanvil",
                                                    "Dankil", "Fireforge", "Frostbeard", "Gorunn", "Holderhek",
                                                    "Ironfist", "Loderr", "Lutgehr", "Rumnaheim", "Strakeln",
                                                    "Torunn", "Ungart"};

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
