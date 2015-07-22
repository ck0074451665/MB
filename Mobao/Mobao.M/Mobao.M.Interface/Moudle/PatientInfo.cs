using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.Interface.Moudle
{
    [DataContract]
    public class PatientInfo
    {
        [DataMember]
        public string PatientName { get; set; }
        [DataMember]
        public string SexName { get; set; }
        [DataMember]
        public string WardName { get; set; }
    }
}
