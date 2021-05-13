using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityGenerator
{
    public class Personality
    {
        private List<string> mainTraits;
        private List<string> minorPositiveTraits;
        private List<string> minorNeutralTraits;
        private List<string> minorNegativeTraits;
        private List<string> ideals;

        public Personality()
        {
            mainTraits = new List<string>();
            minorPositiveTraits = new List<string>();
            minorNeutralTraits = new List<string>();
            minorNegativeTraits = new List<string>();
            ideals = new List<string>();
        }

        public Personality(List<string> main, List<string> minorPositive, List<string> minorNeutral, List<string> minorNegative, List<string> ideals)
        {
            mainTraits = main;
            minorPositiveTraits = minorPositive;
            minorNeutralTraits = minorNeutral;
            minorNegativeTraits = minorNegative;
            this.ideals = ideals;
        }

        public List<string> MainTraits { get => mainTraits; set => mainTraits = value; }
        public List<string> MinorPositiveTraits { get => minorPositiveTraits; set => minorPositiveTraits = value; }
        public List<string> MinorNeutralTraits { get => minorNeutralTraits; set => minorNeutralTraits = value; }
        public List<string> MinorNegativeTraits { get => minorNegativeTraits; set => minorNegativeTraits = value; }
        public List<string> Ideals { get => ideals; set => ideals = value; }
    }
}
