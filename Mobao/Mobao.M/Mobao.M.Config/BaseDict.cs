using Mobao.M.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Mobao.M.Config
{
    public class BaseDict<T, T1> : BaseConfig<Dictionary<T, T1>>
    {
        protected static BaseDict<T, T1> _baseDict;



        protected BaseDict(string subPath)
            : base(subPath)
        {

        }


        protected override Dictionary<string, string> InstanceStruct(System.Xml.Linq.XElement xNode)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (System.Xml.Linq.XNode item in xNode.Nodes())
            {
                dict.Add(((XElement)item).Attribute("key").Value, ((XElement)item).Attribute("value").Value);
            }
            return dict;
        }
    }
}
