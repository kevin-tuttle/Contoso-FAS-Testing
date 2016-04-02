using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso_FAS_Testing
{
    public class TestFunction
    {
        public IEnumerable<TestRequest> TestRequests { get; set; }
        public int TestFunctionId { get; set; }
        public string Name { get; set; }

        public TestFunction(int id)
        {
            // Load data from database
        }
    }
}
