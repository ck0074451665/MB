﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Xml.Linq;
namespace Mobao.M.Utility
{
    public abstract class BaseConfig<T> where T : class
    {
        private string configPath = string.Empty;

        public static T Instance
        {
            get
            {


            }
            private set
            {
                Instance = value;
            }
        }

        private T GetCache(string key)
        {
            Cache cache = new Cache();
            return cache.Get(key) as T;
        }

        private void SetCache(string key, T t)
        {
            Cache cache = new Cache();
            return cache.Add(key, t, new CacheDependency(configPath),DateTime.Now.AddMinutes(30),new TimeSpan()) as T;
        }

        protected BaseConfig(string subPath)
        {
            configPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Config", subPath);
        }

        protected void GetStruct(string subPath)
        {
            if (!File.Exists(configPath))
            {
                throw new ArgumentException("没有找到" + subPath + "文件路径！");
            }
            XDocument xDoc = XDocument.Load(configPath);
            XElement xNode = xDoc.Element("Item");
            var t = InstanceStruct(xNode);
            Instance = t;
        }

        protected abstract T InstanceStruct(XElement xElement);
    }
}