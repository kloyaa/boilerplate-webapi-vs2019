using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi_vs2019.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string UniqueId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }

    }
}