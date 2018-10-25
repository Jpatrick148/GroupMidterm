using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermGroup
{
    class Book
    {
        private string author;
        private string title;
        bool checkedOut = false;
        public Book(string author, string title)
        {
            this.author = author;
            this.title = title;
        }

    }
}
