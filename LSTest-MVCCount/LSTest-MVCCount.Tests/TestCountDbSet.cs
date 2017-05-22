using LSTest_MVCCount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSTest_MVCCount.Tests
{
    class TestCountDbSet : TestDbEnvironmentSet<CountModel>
    {
        public override CountModel Find(params object[] keyValues)
        {
            return this.SingleOrDefault(product => product.ID == (int)keyValues.Single());
        }
    }
}
