using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.Utility
{
    public class LogHelper
    {
        private readonly Common.Logging.ILog log = Common.Logging.LogManager.GetLogger("configFile");
        private static LogHelper _logHelpe;
        public static LogHelper Instance
        {
            get
            {
                if (_logHelpe == null)
                {
                    _logHelpe = new LogHelper();
                }
                return _logHelpe;
            }
        }
        private LogHelper()
        {

        }

        public void Info(string format, params object[] paras)
        {
            log.InfoFormat(format, paras);
        }
        public void Warning(string info, Exception ep)
        {
            log.WarnFormat(info, ep);
        }
        public void Warning(object obj, Exception ep, params object[] paras)
        {
            log.WarnFormat(obj.ToString(), ep, paras);
        }

        public void Debug(string info, Exception ep)
        {
            log.DebugFormat(info, ep);
        }
        public void Debug(object obj, Exception ep, params object[] paras)
        {
            log.DebugFormat(obj.ToString(), ep, paras);
        }
        public void Error(string info, Exception ep)
        {
            log.ErrorFormat(info, ep);
        }
        public void Error(object obj, Exception ep, params object[] paras)
        {
            log.ErrorFormat(obj.ToString(), ep, paras);
        }
    }
}
