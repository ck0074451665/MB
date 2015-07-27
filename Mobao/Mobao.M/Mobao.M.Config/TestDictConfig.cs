using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobao.M.Config
{
    public class TestDictConfig : BaseDict<string, int>
    {
        public static Dictionary<string, int> Instance
        {
            get
            {
                if (_baseDict == null)
                {
                    _baseDict = new TestDictConfig();
                }
                return _baseDict.GetDict();
            }
        }
        public TestDictConfig()
            : base("TestDictConfig.xml")
        {

        }
    }
}
