using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    internal class Puzzles
    {
        string Puzzlename;
        bool complete;
        public Puzzles(string argsPuzzleName, bool argscomplete) 
        { 
            Puzzlename = argsPuzzleName;
            complete = argscomplete;
        }

        public string PuzzleName
        {
            get { return Puzzlename; }
        }
    
        public bool Complete
        {
            get { return complete; }
            set { complete = value; }
        }



    }
}
