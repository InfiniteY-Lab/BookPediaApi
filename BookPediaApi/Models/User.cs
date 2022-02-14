using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookPediaApi.Models
{
    public class User
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string surName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string datee { get; set; }
        public string gender { get; set; }
    }
}