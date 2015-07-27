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


        protected override Dictionary<T, T1> InstanceStruct(System.Xml.Linq.XElement xNode)
        {
            Dictionary<T, T1> dict = new Dictionary<T, T1>();
            foreach (System.Xml.Linq.XNode item in xNode.Nodes())
            {
                AdapterData(dict, item);
            }
            return dict;
        }


        protected virtual void AdapterData(Dictionary<T, T1> dict, System.Xml.Linq.XNode node)
        {
        }
    }
}
