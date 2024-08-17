using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    internal class Books
    {
        //creates 3 variables
        string bookName;
        bool done;
        //sets variables to what was sent when the object was created
        public Books(string argsbookName,  bool argsdone) 
        { 
            bookName = argsbookName;

            done = argsdone;
        }
        //makes the variable public but cannot be changed in other forms
        public string BookName
        {
            get { return bookName; }
        }
        //does the same as above but can be changed outside of class
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }
    }
}
