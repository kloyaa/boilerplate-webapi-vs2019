using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi_vs2019.Models
{
    public class Wallet
    {
        public int Id { get; set; }

        public string UniqueId { get; set; }
        public double Balance { get; set; }
        public double Coins { get; set; }
    }
}