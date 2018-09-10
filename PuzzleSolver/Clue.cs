using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver
{
    internal struct Clue
    {
        ClueType Type {get; set;}
        internal string Attribute1 { get; private set; }
        internal string Attribute2 { get; private set; }
     }

    internal enum ClueType
    {
        Positive,
        Negative
    }
}
