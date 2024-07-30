using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    public class Puzzles
    {
        string Puzzlecode;
        bool complete;
        public Puzzles(string argsPuzzlecode, bool argscomplete) 
        { 
            Puzzlecode = argsPuzzlecode;
            complete = argscomplete;
        }

        public string PuzzleCode
        {
            get { return Puzzlecode; }
        }
    
        public bool Complete
        {
            get { return complete; }
            set { complete = value; }
        }



    }
}
