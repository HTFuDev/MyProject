using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using PACL.DomainModels.Models;

namespace PACL.DomainModels.DBContext
{
    public class PACLDatabaseDbContext : DbContext 
    {
        public DbSet<registration> Registrations { get; set; }
        public DbSet<user> Users { get; set; }
        public DbSet<document> Documents { get; set; }
        public DbSet<receipt> Receipts { get; set; }
        public DbSet<statu> Statuses { get; set; }
        public DbSet<error> Errors { get; set; }
        public DbSet<global> Globals { get; set; }
    }
}
