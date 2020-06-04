using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    public abstract class NameGenerator
    {
        public abstract string GenerateMaleName();

        public abstract string GenerateFemaleName();
    }
}
