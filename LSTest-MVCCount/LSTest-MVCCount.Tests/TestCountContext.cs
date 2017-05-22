using LSTest_MVCCount.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSTest_MVCCount.Models;
using System.Data.Entity;

namespace LSTest_MVCCount.Tests
{

    class TestCountContext : ICounterContext
    {
        public TestCountContext() {
            this.CountNumbers = new TestCountDbSet();
        }
        public DbSet<CountModel> CountNumbers
        {
            get; set;
        }

        public void Dispose(){ }

        public void MarkAsModified<T>(T item) where T : class
        {

        }

        public int SaveChanges()
        {
            return 0;
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
