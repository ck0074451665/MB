using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.Domain
{
    public class TestOne
    {
        public virtual string PkId { get; set; }
        public virtual string UserName { get; set; }

        public virtual List<SubTestOne> SubTest { get; set; }
    }

    public class SubTestOne
    {
        public string Name { get; set; }
    }
}
