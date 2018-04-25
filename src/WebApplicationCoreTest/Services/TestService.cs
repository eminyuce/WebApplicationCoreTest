using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCoreTest.Services
{
    public class TestService : ITestService
    {
        public int TestSum(int i, int y)
        {
            return i + y;
        }
    }
}
