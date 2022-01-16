using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication2_with_NTTFramework.Models
{
    public partial class GroupDBContext : DbContext
    {
        public GroupDBContext()
            : base("name=GroupDBContext")
        {
        }
        public virtual DbSet<Football> Footballs { get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
