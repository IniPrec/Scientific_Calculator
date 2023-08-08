using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificCalculator
{
    public static class Validation
    {
        public static bool isNumeric(string input)
        {
            double number;
            return double.TryParse(input, out number);
        }
    }
}
