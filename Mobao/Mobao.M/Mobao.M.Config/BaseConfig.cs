using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Mobao.M.Utility
{
    public abstract class BaseConfig<T> where T : class
    {
        private string configPath = string.Empty;
        public BaseConfig(string subPath)
        {
            configPath = subPath;
        }

        public T GetStruct(string subPath)
        {
            string fullPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Config", "");
            if (!File.Exists(fullPath))
            {
                throw new ArgumentException("没有找到" + subPath + "文件路径！");
            }
            XDocument xDoc = XDocument.Load(configPath);
            XNode xNode = xDoc.FirstNode;
            return InstanceStruct(xNode);
        }

        protected abstract T InstanceStruct(XNode xNode);
    }
}
