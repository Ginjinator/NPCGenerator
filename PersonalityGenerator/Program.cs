using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            MainTraitsGenerator mainTraits = new MainTraitsGenerator();
            mainTraits.generateMainTraits();
            mainTraits.printMainTraitsWithValues();

            MinorTraitsGenerator minorTraits = new MinorTraitsGenerator();
            minorTraits.generatePositiveTraits();
            minorTraits.generateNeutralTraits();
            minorTraits.generateNegativeTraits();
            minorTraits.printGeneratedMinorTraits();

            IdealsGenerator ideals = new IdealsGenerator();
            ideals.generateIdeals();
            ideals.printIdeals();
        }
    }
}
