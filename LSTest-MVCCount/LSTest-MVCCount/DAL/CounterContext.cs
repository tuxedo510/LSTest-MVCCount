using LSTest_MVCCount.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace LSTest_MVCCount.DAL
{
    public class CounterContext : DbContext, ICounterContext
    {
        public CounterContext() : base("LSTest-MVCCount")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CounterContext>());
        }
 
        public DbSet<CountModel> CountNumbers { get; set; }

        public void MarkAsModified<T>(T item) where T : class
        {
            Entry(item).State = EntityState.Modified;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}