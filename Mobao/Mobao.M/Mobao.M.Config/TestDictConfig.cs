using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobao.M.Config
{
    public class TestDictConfig : BaseDict
    {
        public static Dictionary<string, string> Instance
        {
            get
            {
                if (_testDict == null)
                {
                    _testDict = new TestDictConfig();
                }
                return _testDict.GetDict();
            }
        }
        public TestDictConfig()
            : base("TestDictConfig.xml")
        {

        }
    }
}
