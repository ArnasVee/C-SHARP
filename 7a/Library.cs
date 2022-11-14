using System;
using System.Collections.Generic;
using System.Text;

namespace _7a_pamoka
{
    public class Library
    {
        public Library(Address address)
        {
            Address = address;
            Books = new List<Books>();
            Magazines = new List<Magazine>();
        }

        public Address Address { get; set; }
        public  List<Books> Books { get; set; }
        public List<Magazine> Magazines { get; set; }


    }
}
