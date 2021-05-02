using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi_vs2019.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public string UniqueId { get; set; }

        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string DateAdded { get; set; }
    }
}