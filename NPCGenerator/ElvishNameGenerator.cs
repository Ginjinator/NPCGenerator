using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class ElvishNameGenerator : NameGenerator
    {
        List<string> maleNames = new List<string> {"Adran", "Aelar", "Aramil", "Arannis",
            "Aust", "Beiro", "Berrian", "Carric" , "Enialis", "Erdan", "Erevan",
            "Galinndan", "Hadarai", "Heian", "Himo", "Immeral", "Ivellios",
            "Laucian", "Mindartis", "Paelias", "Peren", "Quarion", "Riardon",
            "Rolen", "Soveliss", "Thamior", "Tharivol", "Theren", "Varis"};
        List<string> femaleNames = new List<string> {"Adrie", "Althaea", "Anastrianna",
            "Andraste", "Antinua", "Bethrynna", "Birel", "Caelynn",
            "Drusilia", "Enna", "Felosial", "Ielenia", "Jelenneth", "Keyleth",
            "Leshanna", "Lia", "Meriele", "Meialee", "Naivara", "Quelenna",
            "Quillathe", "Sariel", "Shanairra", "Shava", "Silaqui",
            "Theirastra", "Thia", "Vadania", "Valanthe", "Xanaphia"};
        List<string> familyNames = new List<string> {"Amakiir", "Amastacia", "Galanodel",
            "Holimion", "Ilphelkiir", "Liadon", "Meliamne",
            "Nai'lo", "Siannodel", "Xiloscient"};

        private string createdName = "";
        Random random = new Random();

        public override string GenerateMaleName()
        {
            var pickFullName = random.Next(1, 5);
            if (pickFullName == 5)
            {
                createdName = maleNames[random.Next(0, maleNames.Count - 1)];
                var familyName = " " + GenerateFamilyName();
                createdName += familyName;
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
                var clanName = " " + GenerateFamilyName();

                createdName += clanName;
                return createdName;
            }
        }

        public override string GenerateFemaleName()
        {
            var pickFullName = random.Next(1, 5);
            if (pickFullName == 5)
            {
                createdName = femaleNames[random.Next(0, femaleNames.Count - 1)];
                var familyName = " " + GenerateFamilyName();
                createdName += familyName;
                return createdName;
            }
            int halfOfName = 0;
            var name1 = femaleNames[random.Next(0, femaleNames.Count - 1)];
            var name2 = femaleNames[random.Next(0, femaleNames.Count - 1)];

            halfOfName = (name1.Length / 2);
            var firstHalf = name1.Substring(0, halfOfName);
            halfOfName = (name2.Length / 2);
            var secondHalf = name2.Substring(halfOfName);

            createdName = firstHalf + secondHalf;
            var clanName = " " + GenerateFamilyName();

            createdName += clanName;
            return createdName;
        }

        public string GenerateFamilyName()
        {
            var pickFullName = random.Next(1, 5);
            if (pickFullName == 5)
            {
                var familyName = " " + familyNames[random.Next(0, familyNames.Count - 1)];
                return familyName;
            }
            else
            {
                int halfOfName = 0;
                var name1 = familyNames[random.Next(0, familyNames.Count - 1)];
                var name2 = familyNames[random.Next(0, familyNames.Count - 1)];

                halfOfName = (name1.Length / 2);
                var firstHalf = name1.Substring(0, halfOfName);
                halfOfName = (name2.Length / 2);
                var secondHalf = name2.Substring(halfOfName);

                var familyName = firstHalf + secondHalf;
                return familyName;
            }
        }
    }
}
