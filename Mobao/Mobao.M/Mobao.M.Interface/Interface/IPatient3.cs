using Mobao.M.Interface.Moudle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Mobao.M.Interface
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IPatient3
    {
        [OperationContract]
        List<PatientInfo> GetPatientInfo();

        [OperationContract]
        string Test();

        [OperationContract]
        PatientInfo GetPatientInfoEntity();

    }
}
