﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobao.M.Utility;

namespace Mobao.M.Config.Test
{
    [Category("config")]
    [TestFixture]
    public class ConfigTest
    {
        [Test]
        [ExpectedException()]
        public void TestDict()
        {
           Console.WriteLine(TestDictConfig.Instance["name"].SafeToInt());
        }
    }
}