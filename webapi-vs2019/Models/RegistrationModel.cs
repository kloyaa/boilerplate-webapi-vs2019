using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webapi_vs2019.Models
{
    public class RegistrationModel
    {
		[Required]
		public string UserName { get; set; }
		[Required]
		public string Password { get; set; }
		public string Role { get; set; }
		// Add you Registration fields here...
		//public string LastName { get; set; }
		//public string FirstName { get; set; }
	}
}