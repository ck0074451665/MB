using Mobao.M.Domain;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobao.M.Config.Test
{
    [TestFixture]
    public class TestNhibernate
    {
        [Test]
        public void TestConnection()
        {
            Mobao.M.Domain.IRepository<TestOne> repo = new Mobao.M.NHibernate.TestOneRepository();
            repo.Add(new TestOne());
        }

    }
}
