using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAppProject.Models
{
    public class BankMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Passsword { get; set; }

        public List<BankTransaction> Transactions { get; set; }
        public BankMaster()
        {
            this.Transactions = new List<BankTransaction>();
            BankTransaction transaction = new BankTransaction();
            transaction.Type = AccountType.D;
            transaction.CustName = Name;
            transaction.Amount = Balance;
            transaction.Date = System.DateTime.Today;

        }        

    }
}