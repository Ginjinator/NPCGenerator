using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    public class GenerateName
    {
        private string name = "";
        public GenerateName()
        {
            name = "No name generated";
        }

        public GenerateName(string gender)
        {
            name = "No race selected";
        }

        public GenerateName(string gender, string race)
        {
            if (gender.Equals("male", StringComparison.InvariantCultureIgnoreCase))
            {
                name = GenerateMaleName(race);
            }
            else if (gender.Equals("female", StringComparison.InvariantCultureIgnoreCase))
            {
                name = GenerateFemaleName(race);
            }
            else
            {
                name = "Invalid Race Input";
            }
        }

        public string getName()
        {
            return name;
        }

        public string GenerateMaleName(string race)
        {
            var maleName = "";

            //Try switch case statement instead of if else if
            if (race.Equals("human", StringComparison.InvariantCultureIgnoreCase))
            {
                HumanNameGenerator humanName = new HumanNameGenerator();
                humanName.GenerateMaleName();
            }
            else if (race.Equals("dwarf", StringComparison.InvariantCultureIgnoreCase)) {
                DwarvenNameGenerator dwarvenName = new DwarvenNameGenerator();
                maleName = dwarvenName.GenerateMaleName();
            }
            else if (race.Equals("dragonborn", StringComparison.InvariantCultureIgnoreCase))
            {
                DragonbornNameGenerator dragonbornName = new DragonbornNameGenerator();
                maleName = dragonbornName.GenerateMaleName();
            }
            else if (race.Equals("tiefling", StringComparison.InvariantCultureIgnoreCase))
            {
                TieflingNameGenerator tieflingName = new TieflingNameGenerator();
                maleName = tieflingName.GenerateMaleName();
            }

            return maleName;
        }

        public string GenerateFemaleName(string race)
        {
            var femaleName = "";
            if (race.Equals("human", StringComparison.InvariantCultureIgnoreCase))
            {
                HumanNameGenerator humanName = new HumanNameGenerator();
                humanName.GenerateFemaleName();
            }
            else if (race.Equals("dwarf", StringComparison.InvariantCultureIgnoreCase))
            {
                DwarvenNameGenerator dwarvenName = new DwarvenNameGenerator();
                femaleName = dwarvenName.GenerateFemaleName();
            }
            else if (race.Equals("dragonborn", StringComparison.InvariantCultureIgnoreCase))
            {
                DragonbornNameGenerator dragonbornName = new DragonbornNameGenerator();
                femaleName = dragonbornName.GenerateFemaleName();
            }
            else if (race.Equals("tiefling", StringComparison.InvariantCultureIgnoreCase))
            {
                TieflingNameGenerator tieflingName = new TieflingNameGenerator();
                femaleName = tieflingName.GenerateFemaleName();
            }

            return femaleName;
        }
    }
}
