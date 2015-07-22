using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.Domain
{
    public class PatientWardRelation
    {
        public virtual string Id { get; set; }

        public virtual string WId { get; set; }

        public virtual Ward WardEntity { get; set; }

        public virtual string PId { get; set; }

        public virtual Patient PatientEntity { get; set; }

    }
}
