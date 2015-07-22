using Mobao.M.Interface.Moudle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.Interface
{
    [ServiceContract]
    public interface IPatient
    {
        [OperationContract]
        List<PatientInfo> GetPatientInfo();
    }
}
