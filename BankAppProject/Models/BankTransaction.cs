using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAppProject.Models
{
    public class BankTransaction
    {
        public int Id { get; set; }
        public string CustName { get; set; }
        public double Amount { get; set; }
        public AccountType Type { get; set; }

        public DateTime Date { get; set; }

    }
}