using Mobao.M.Data;
using Mobao.M.Data.Domain;
using Mobao.M.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.NHibernate
{
    public class TestOneRepository : Repository<TestOne>, ITestOneRepository
    {
        public void Init()
        {
        }
    }
}
