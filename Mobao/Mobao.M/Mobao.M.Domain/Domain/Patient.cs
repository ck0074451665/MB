using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobao.M.Domain.Domain;

namespace Mobao.M.Domain
{

    public enum Sex
    {
        [Description("男")]
        Man = 0,
        [Description("女")]
        Women = 1
    }
    [DataContract]
    public class Patient
    {
        public virtual string Id { get; set; }

        public virtual string Name { get; set; }

        public virtual DateTime Brithday { get; set; }

        public virtual Sex Sex { get; set; }

        public virtual string Remark { get; set; }
    }
}
