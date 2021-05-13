using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> racesList = new List<string> { "Human", "Dwarf", "Dragonborn", "Tiefling", "Elf", "Gnome", "Halfling", "Half-Orc" };
            var gender = "";
            var race = "";

            bool shouldContinue = true;
            while (shouldContinue)
            {
                bool accept = false;
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

                GenerateName generatedName = new GenerateName(gender, race);
                Console.WriteLine(generatedName.getName());

                accept = false;
                while (!accept)
                {
                    Console.WriteLine("Continue?");
                    var answer = Console.ReadLine();
                    if (answer.Equals("yes", StringComparison.InvariantCultureIgnoreCase) || answer.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                    {
                        accept = true;
                        shouldContinue = true;
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
}
