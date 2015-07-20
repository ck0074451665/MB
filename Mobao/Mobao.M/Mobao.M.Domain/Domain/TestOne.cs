using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.Domain
{
    public class TestOne
    {
        public string UserName { get; set; }

        public List<SubTestOne> SubTest { get; set; }
    }

    public class SubTestOne
    {
        public string Name { get; set; }
    }
}
