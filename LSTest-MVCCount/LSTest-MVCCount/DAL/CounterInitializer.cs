using LSTest_MVCCount.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LSTest_MVCCount.DAL
{
    public class CounterInitializer : DropCreateDatabaseIfModelChanges<CounterContext>
    {
        protected override void Seed(CounterContext context)
        {
            var counter = new List<CountModel>
            {
                new CountModel { Count = 0 }
            };

            counter.ForEach(count => context.CountNumbers.Add(count));
            context.SaveChanges();
        }
    }
}