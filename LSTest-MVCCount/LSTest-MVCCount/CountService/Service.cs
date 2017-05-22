using LSTest_MVCCount.DAL;
using LSTest_MVCCount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LSTest_MVCCount.CountService
{
    public class CounterService : ICounterService
    {
        ICounterContext _context;

        public CounterService()
        {
            _context = new CounterContext();
        }

        public CounterService(ICounterContext context)
        {
            _context = context;
        }

        public int IncreaseCount()
        {
            CountModel count = _context.CountNumbers.FirstOrDefault();
            if (count == null)
            {
                count = _context.CountNumbers.Add(new CountModel { Count = 0 });
                _context.SaveChanges();
            }

            if (count.Count < 10)
            {
                count.Count += 1;
                _context.SaveChanges();
            }

            return count.Count;
        }

        public int GetCurrentCount()
        {
            CountModel count = _context.CountNumbers.FirstOrDefault();
            if (count == null)
            {
                count = _context.CountNumbers.Add(new CountModel { Count = 0 });
                _context.SaveChanges();
            }
            return count.Count;
        }

        public int ResetCount()
        {
            CountModel count = _context.CountNumbers.FirstOrDefault();
            if (count == null)
            {
                count = _context.CountNumbers.Add(new CountModel { Count = 0 });
                _context.SaveChanges();
            }
            count.Count = 0;
            _context.SaveChanges();
            return count.Count;
        }
    }
}