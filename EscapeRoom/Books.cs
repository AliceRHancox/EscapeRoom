using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    internal class Books
    {
        string bookName;
        int whichBook;
        bool done;
        public Books(string argsbookName, int argswhichBook, bool argsdone) 
        { 
            bookName = argsbookName;
            whichBook = argswhichBook;
            done = argsdone;
        }

        public string BookName
        {
            get { return bookName; }
        }

        public int WhichBook
        {
            get { return whichBook; }
        }

        public bool Done
        {
            get { return done; }
            set { done = value; }
        }
    }
}
