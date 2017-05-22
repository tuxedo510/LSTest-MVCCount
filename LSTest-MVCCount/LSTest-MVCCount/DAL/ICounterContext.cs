using LSTest_MVCCount.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LSTest_MVCCount.DAL
{
    public interface ICounterContext : IDisposable
    {
        DbSet<CountModel> CountNumbers { get; }
        int SaveChanges();
        Task<int> SaveChangesAsync();
        void MarkAsModified<T>(T item) where T : class;
    }
}