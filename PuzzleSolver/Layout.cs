using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver
{
    internal class Layout
    {
        private IEnumerable<Clue> clues;    

        internal Layout FindSolution(IEnumerable<Clue> clues)
        {
            this.clues = clues;
            ApplyClues();
        }

        internal void ApplyClues(IEnumerable<Clue> clues)
        {
            throw new NotImplementedException();
        }
    }
}
