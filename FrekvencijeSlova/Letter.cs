using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrekvencijeSlova
{
    public class Letter
    {
        public int Frequency { get; set; }
        public char LetterName { get; set; }
        public Letter()
        {
            Frequency = 1;
        }
        public override string ToString()
        {
            return LetterName.ToString() + " --> " + Frequency.ToString() + Environment.NewLine;
        }
    }
}
