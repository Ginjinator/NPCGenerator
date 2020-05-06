using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCGenerator
{
    class DragonbornNameGenerator : NameGenerator
    {
        List<string> maleNames = new List<string> {"Arjhan", "Balasar", "Bharash", "Donaar", "Ghesh",
                                                    "Heskan", "Kriv", "Medrash", "Mehen", "Nadarr", "Pandjed",
                                                    "Patrin", "Rhogar", "Shamash", "Shedinn", "Tarhun", "Torinn"};

        List<string> femaleNames = new List<string> {"Akra", "Biri", "Daar", "Farideh", "Harann",
                                                    "Flavilar", "Jheri", "Kava", "Korinn", "Mishann", "Nala", "Perra",
                                                    "Raiann", "Sora", "Surina", "Thava", "Uadjit"};

        List<string> clanNames = new List<string> {"Clethtinthiallor", "Daardendrian", "Delmirev",
                                                    "Drachedandion", "Fenkenkabradon", "Kepeshkmolik",
                                                    "Kerrhylon", "Kimbatuul", "Linxakasendalor", "Myastan",
                                                    "Nemmonis", "Norixius", "Ophinshtalajiir", "Prexijandilin",
                                                    "Shestendeliath", "Turnuroth", "Verthisathurgiesh", "Yarjerit"};

        private string createdName = "";
        Random random = new Random();

        public override string GenerateMaleName()
        {
            int halfOfName = 0;
            var name1 = maleNames[random.Next(0, maleNames.Count) - 1];
            var name2 = maleNames[random.Next(0, maleNames.Count) - 1];

            halfOfName = (name1.Length / 2);
            var firstHalf = name1.Substring(0, halfOfName);
            halfOfName = (name2.Length / 2);
            var secondHalf = name2.Substring(halfOfName);

            createdName = firstHalf + secondHalf;
            var clanName = " " + GenerateClanName();

            createdName += clanName;
            return createdName;
        }

        public override string GenerateFemaleName()
        {
            int halfOfName = 0;
            var name1 = femaleNames[random.Next(0, femaleNames.Count) - 1];
            var name2 = femaleNames[random.Next(0, femaleNames.Count) - 1];

            halfOfName = (name1.Length / 2);
            var firstHalf = name1.Substring(0, halfOfName);
            halfOfName = (name2.Length / 2);
            var secondHalf = name2.Substring(halfOfName);

            createdName = firstHalf + secondHalf;
            var clanName = " " + GenerateClanName();

            createdName += clanName;
            return createdName;
        }

        public string GenerateClanName()
        {
            int thirdOfName = 0;
            var name1 = clanNames[random.Next(0, clanNames.Count) - 1];
            var name2 = clanNames[random.Next(0, clanNames.Count) - 1];
            var name3 = clanNames[random.Next(0, clanNames.Count) - 1];

            thirdOfName = (name1.Length / 3);
            var firstThird = name1.Substring(0, thirdOfName);
            thirdOfName = (name2.Length / 3);
            var secondThird = name2.Substring(thirdOfName, (thirdOfName * 2));
            thirdOfName = (name3.Length / 3);
            var lastThird = name3.Substring(thirdOfName * 2);

            var clanName = firstThird + secondThird + lastThird;
            return clanName;
        }
    }
}