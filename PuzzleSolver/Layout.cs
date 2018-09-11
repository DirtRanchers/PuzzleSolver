using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver
{
    internal class Layout
    {
        internal Layout(Attributes attributes, IEnumerable<Clue> clues)
        {
            //TODO init appropriately, instead of 0/0/0
            values = new string[0,0,0];
            ApplyClues(clues);
        }

        internal Layout(Layout layout)
        {
            //TODO: make this a deep clone instead of shallow
            this.values = (string[,,])layout.values.Clone();
        }

        private IEnumerable<Clue> clues;    

        internal Layout FindSolution(IEnumerable<Clue> clues)
        {
            this.clues = clues;
            ApplyClues();
        }

        //TODO: implement
        public bool IsSolution => false;

        //TODO: implement
        public bool IsInvalid => false;

        private void ApplyClues(IEnumerable<Clue> clues)
        {
            throw new NotImplementedException();
        }


        private string[,,] values;
    }
}
