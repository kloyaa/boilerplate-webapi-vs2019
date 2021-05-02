using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi_vs2019.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string UniqueId { get; set; }
        public string TransactionDate { get; set; }
        public string TransactionName { get; set; }
        public double TransactionAmount { get; set; }
        public string TransactionWith { get; set; }
        public string TransactionStatus { get; set; }
        public double AccountBalance { get; set; }

    }
}