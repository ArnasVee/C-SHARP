using System;
using System.Collections.Generic;
using System.Text;

namespace _7a_pamoka
{
    public class Books:Publication
    {    
        public Books(string isbn):base(isbn)
        {
            
        }


        public Author Author { get; set; }
        public bool IsAvailable { get; set; }
        public Genre Genre { get; set; }      
    }
}
