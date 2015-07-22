using Mobao.M.Domain;
using Mobao.M.Utility;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.Config.Test
{
    [Category("EnumHelper")]
    [TestFixture]
    public class TestEnumHeler
    {
        [Test]
        public void TestGetDescription()
        {
          Console.WriteLine( EnumHelper.GetDescription(Sex.Man));
        }
    }
}
