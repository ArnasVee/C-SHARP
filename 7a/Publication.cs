using System;
using System.Collections.Generic;
using System.Text;

namespace _7a_pamoka
{
    public class Publication
    {
        public Publication(string isbn)
        {
            ISBN = isbn;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
