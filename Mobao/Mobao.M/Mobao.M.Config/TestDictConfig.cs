using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

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

        protected override void AdapterData(Dictionary<string, int> dict, System.Xml.Linq.XNode node)
        {
            dict.Add(((XElement)node).Attribute("key").Value,
                int.Parse(((XElement)node).Attribute("value").Value));
        }
    }
}
