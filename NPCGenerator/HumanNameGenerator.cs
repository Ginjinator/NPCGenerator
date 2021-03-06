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

        List<string> maleNames = new List<string> {"Anlow", "Arando", "Bram", "Cale", "Dalkon", "Daylen", "Dodd", "Dungarth", "Dyrk",
            "Eandro", "Falken", "Feck", "Fenton", "Gryphero", "Hagar", "Jeras", "Krynt", "Lavant", "Leyten", "Madian", "Malfier", "Markus", "Meklan", "Namen",
            "Navaren", "Nerle", "Nilus", "Ningyan", "Norris", "Quentin", "Semil", "Sevenson", "Steveren", "Talfen", "Tamond", "Taran", "Tavon", "Tegan", "Vanan", "Vincent"};
        List<string> femaleNames = new List<string> { "Azura", "Brey", "Hallan", "Kasaki", "Lorelei", "Mirabel", "Pharana", "Remora", "Rosalyn", "Sachil", "Saidi",
            "Tanika", "Tura", "Tylsa", "Vencia", "Xandrilla"};
        List<string> familyNames = new List<string> { "Arkalis", "Armanci", "Bilger", "Blackstrand", "Brightwater", "Carnavon", "Caskajaro", "Coldshore",
            "Coyle", "Cresthill", "Cuttlescar", "Daargen", "Dalicarlia", "Danamark", "Donoghan", "Drumwind", "Dunhall", "Ereghast", "Falck", "Fallenbridge",
            "Faringray", "Fletcher", "Fryft", "Goldrudder", "Grantham", "Graylock", "Gullscream", "Hindergrass", "Iscalon", "Kreel", "Kroft", "Lamoth",
            "Leerstrom", "Lynchfield", "Moonridge", "Netheridge", "Oakenheart", "Pyncion", "Ratley", "Redraven", "Revenmar", "Roxley", "Sell", "Seratolva", "Shanks",
            "Shattermast", "Shaulfer", "Silvergraft", "Stavenger", "Stormchapel", "Strong", "Swiller", "Talandro ", "Targana", "Towerfall", "Umbermoor", "Varcona",
            "Varzand", "Voortham", "Vrye", "Webb", "Welfer", "Wilxes", "Wintermere", "Wygarthe", "Zatchet", "Zethergyll"};

        private string createdName = "";
        Random random = new Random();

        //TODO: Possible: Move all name generation to common class, and call that with gender and race passed in
        public override string GenerateMaleName()
        {
            // Chance to get full name from list above
            // breaks out if using full name from list
            var pickFullName = random.Next(1, 5);
            if (pickFullName >= 4)
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
                var familyName = " " + GenerateFamilyName();

                createdName += familyName;
                return createdName;
            }
        }

        public override string GenerateFemaleName()
        {
            // Chance to get full name from list above
            // breaks out if using full name from list
            var pickFullName = random.Next(1, 5);
            if (pickFullName == 5)
            {
                createdName = femaleNames[random.Next(0, femaleNames.Count - 1)];
                var familyName = " " + GenerateFamilyName();
                createdName += familyName;
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
                var family = " " + GenerateFamilyName();

                createdName += family;
                return createdName;
            }
        }

        public string GenerateFamilyName()
        {
            // Chance to get full name from list above
            // breaks out if using full name from list
            var fullName = random.Next(1, 5);
            if (fullName >= 4)
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
