using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookPediaApi.Models
{
    public class Inventory
    {
        public int id { get; set; }
        public string authorName { get; set; }
        public string postTitle { get; set; }
        public string type { get; set; }
        public string bookURL { get; set; }
        public string blogPost { get; set; }
        public string save { get; set; }
        public string category { get; set; }


    }
}