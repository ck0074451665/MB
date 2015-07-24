using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace Mobao.M.Service
{
    public class ParameterInspector : IParameterInspector
    {
        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
            Mobao.M.Utility.LogHelper.Instance.Info("操作信息:" + correlationState.ToString());
        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            return "调用操作:" + operationName + ",参数信息：" + string.Join(",", inputs == null ? string.Empty : string.Join(",", inputs.ToArray()));
        }
    }
}