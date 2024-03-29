﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace webapi_vs2019.Models
{
    public class dbContext : DbContext
    {
        public dbContext() : base("web002ApiDb") { }
        public DbSet<UserAccount> Users { get; set; }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }
}