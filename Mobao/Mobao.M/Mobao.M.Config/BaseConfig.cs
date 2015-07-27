using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;
using System.Xml.Linq;
namespace Mobao.M.Utility
{
    public abstract class BaseConfig<T> where T : class
    {
        const string ROOT_ELEMENT = "config";
        const string RELATIVE_PATH = "Config";

        protected string configPath = string.Empty;


        protected T GetCache(string key)
        {
            Cache cache = HttpRuntime.Cache;
            object obj = cache.Get(key);
            return obj == null ? null : obj as T;
        }

        protected void SetCache(string key, T t)
        {
            Cache cache = HttpRuntime.Cache;
            cache.Add(key, t, new CacheDependency(configPath),
               System.Web.Caching.Cache.NoAbsoluteExpiration, new TimeSpan(0, 20, 0), CacheItemPriority.Default, null);
        }

        protected BaseConfig(string subPath)
        {
            configPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory + RELATIVE_PATH, subPath);
        }


        public T GetDict()
        {
            T obj = GetCache(configPath);
            if (obj == null)
            {
                obj = GetStruct(configPath);
                SetCache(configPath, obj);
            }
            return obj;
        }

        protected T GetStruct(string subPath)
        {
            if (!File.Exists(configPath))
            {
                throw new ArgumentException("没有找到" + subPath + "文件路径！");
            }
            XDocument xDoc = XDocument.Load(configPath);
            XElement xNode = xDoc.Element(ROOT_ELEMENT);
            if (xNode == null)
            {
                throw new ArgumentException("是否没有元素或者根目录不是\"" + ROOT_ELEMENT + "\"");
            }
            var t = InstanceStruct(xNode);
            return t;
        }

        protected abstract T InstanceStruct(XElement xElement);
    }
}
