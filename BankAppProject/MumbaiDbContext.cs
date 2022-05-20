using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BankAppProject.Models;

namespace BankAppProject
{
    public class MumbaiDbContext:DbContext
    {
        public DbSet<BankMaster> BankMasters { get; set; }
        public DbSet<BankTransaction> Transactions { get; set; }
    }
}