using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver
{
    internal class Solver
    {
        internal void Run(Attributes attributes, IEnumerable<Clue> clues)
        {
            this.attributes = attributes;
            clues = clues.ToArray();
            initialLayout = new Layout(attributes, clues);
            solution = initialLayout.FindSolution(clues);
        }

        private Clue[] clues;
        private Attributes attributes;
        private Layout initialLayout;
        private Layout solution;


    }
}
