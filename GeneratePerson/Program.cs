using NameGenerator;
using PersonalityGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratePerson
{
    class Program
    {
        static List<string> racesList = new List<string> { "Human", "Dwarf", "Dragonborn", "Tiefling", "Elf", "Gnome", "Halfling", "Half-Orc" };
        static bool shouldContinue = true;
        static int increment = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Generate NPC");
            Console.WriteLine();
            while (shouldContinue)
            {
                //TODO: Allow to create more of the recent choice
                Console.WriteLine("Create New Person: ");
                Console.WriteLine("1: Completely Random");
                Console.WriteLine("2: Pick Race and Gender");
                Console.WriteLine("Choice: ");

                int caseSwitch = 0;
                var userChoice = Console.ReadLine();
                bool isNum = int.TryParse(userChoice, out caseSwitch);

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Completely Random NPC");
                        GenerateRandom();
                        break;
                    case 2:
                        Console.WriteLine("Fixed NPC");
                        GenerateFixed();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        shouldContinue = true;
                        break;
                }
            }
        }

        private static void GenerateRandom()
        {
            Random random = new Random();

            string gender = "";
            string race = "";

            int maleOrFemale = random.Next(1, 2);
            if (maleOrFemale == 1)
            {
                gender = "male";
            }
            if (maleOrFemale == 2)
            {
                gender = "female";
            }

            int raceChoice = random.Next(0, racesList.Count - 1);
            race = racesList[raceChoice];
            Console.WriteLine(gender + " " + race);
            GenerateName newName = new GenerateName(gender, race);
            Console.WriteLine(newName.getName() + "\n");
            Personality personality = new Personality();

        }

        private static void GenerateFixed()
        {
            bool accept = false;
            string gender = "";
            string race = "";
            
            while (!accept)
            {
                Console.WriteLine("Pick a gender: ");
                gender = Console.ReadLine();
                if (gender.Equals("male", StringComparison.InvariantCultureIgnoreCase) || gender.Equals("female", StringComparison.InvariantCultureIgnoreCase))
                {
                    accept = true;
                }
                else
                {
                    Console.WriteLine("I don't have names for that gender please try male or female.");
                    accept = false;
                }
            }

            Console.WriteLine("You chose " + gender.ToLower());
            Console.WriteLine();

            accept = false;
            while (!accept)
            {
                Console.WriteLine("Please select a race: ");
                race = Console.ReadLine();
                foreach (string raceInList in racesList)
                {
                    if (race.Equals(raceInList, StringComparison.InvariantCultureIgnoreCase))
                    {
                        accept = true;
                        break;
                    }
                    else
                    {
                        accept = false;
                    }
                }
                if (accept == false)
                {
                    Console.WriteLine("I don't have names for that race please try one of the following: ");
                    racesList.ForEach(Console.WriteLine);
                }
            }

            GenerateName newName = new GenerateName(gender, race);
            var makeListAnswer = "";
            Console.WriteLine("List of 10?: ");
            makeListAnswer = Console.ReadLine();
            if (makeListAnswer.Equals("y", StringComparison.InvariantCultureIgnoreCase) || makeListAnswer.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
            {
                for(int i = 0; i <= 9; i++)
                {
                    Console.WriteLine(newName.getName());
                    newName = new GenerateName(gender, race);
                    //Wait - Too fast and generates same name without this
                    System.Threading.Thread.Sleep(100);
                }
            }
            else
            {
                Console.WriteLine(newName.getName());
            }
            //Personality personality = new Personality();

            //MainTraitsGenerator mainTraits = new MainTraitsGenerator();
            //mainTraits.generateMainTraits();
            //mainTraits.printMainTraitsWithValues();

            //MinorTraitsGenerator minorTraits = new MinorTraitsGenerator();
            //minorTraits.generatePositiveTraits();
            //minorTraits.generateNeutralTraits();
            //minorTraits.generateNegativeTraits();
            //minorTraits.printGeneratedMinorTraits();

            //IdealsGenerator ideals = new IdealsGenerator();
            //ideals.generateIdeals();
            //ideals.printIdeals();

            accept = false;
            while (!accept)
            {
                Console.WriteLine("");
                Console.WriteLine("Continue?");
                var answer = Console.ReadLine();
                if (answer.Equals("yes", StringComparison.InvariantCultureIgnoreCase) || answer.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                {
                    accept = true;
                    shouldContinue = true;
                    increment++;
                }
                else if (answer.Equals("no", StringComparison.InvariantCultureIgnoreCase) || answer.Equals("n", StringComparison.InvariantCultureIgnoreCase))
                {
                    accept = true;
                    shouldContinue = false;
                }
                else
                {
                    Console.WriteLine("Not an acceptable answer, please say 'yes' or 'no'");
                    accept = false;
                }
            }
        }
    }
}
