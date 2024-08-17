using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    public class Puzzles
    {
        //creates variables
        string Puzzlecode;
        bool complete;
        //sets variables to what was sent when the object was created
        public Puzzles(string argsPuzzlecode, bool argscomplete) 
        { 
            Puzzlecode = argsPuzzlecode;
            complete = argscomplete;
        }
        //makes the variable public but cannot be changed in other forms
        public string PuzzleCode
        {
            get { return Puzzlecode; }
        }
        //does the same as above but can be changed outside of class
        public bool Complete
        {
            get { return complete; }
            set { complete = value; }
        }



    }
}
