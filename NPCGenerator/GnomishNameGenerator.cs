using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class GnomishNameGenerator : NameGenerator
    {
        List<string> maleNames = new List<string> {"Alvyn", "Boddynock", "Brocc", "Burgell",
            "Dimble", "Eldon", "Erky", "Fonkin", "Frug", "Gerbo", "Gimble",
            "Glim", "Jebeddo", "Kellen", "Namfoodle", "Orryn", "Roondar",
            "Seebo", "Sindri", "Warryn", "Wrenn", "Zook"};
        List<string> femaleNames = new List<string> {"Bimpnottin", "Breena", "Caramip", "Carlin",
            "Donella", "Duvamil", "Ella", "Ellyjobell", "Ellywick", "Lilli",
            "Loopmottin", "Lorilla", "Mardnab", "Nissa", "Nyx", "Oda", "Orla",
            "Roywyn", "Shamil", "Tana", "Waywocket", "Zanna"};
        List<string> clanNames = new List<string> {"Beren", "Daergel", "Folkor", "Garrick", "Nackle",
            "Murnig", "Ningel", "Raulnor", "Scheppen", "Timbers", "Turen", "Abren",
            "Aelnor", "Bachin", "Banilor", "Blackrock", "Blimth", "Danask", "Durim", "Fasketel", "Furnak",
            "Galeb", "Greatorm", "Grosko", "Hardin", "Hymnir", "Jarnak", "Kellen", "Kyri", "Lundor", "Merren",
            "Nessik", "Pernor", "Quindal", "Ranadal", "Rivenstone", "Rustek", "Rutvor", "Sasken", "Shasto",
            "Skerrit", "Tamble", "Tavartarr", "Terrick", "Turco", "Urvor", "Uvarkk", "Vandek", "Vilio", "Walnir",
            "Whitehorn", "Yimble"};


        private string createdName = "";
        Random random = new Random();

        public override string GenerateMaleName()
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

        public override string GenerateFemaleName()
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

        public string GenerateClanName()
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
