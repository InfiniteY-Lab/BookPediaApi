using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookPediaApi.Models
{
    public class Book
    {
        public int id { get; set; }
        public string bookName { get; set; }
        public string author { get; set; }
    }
}