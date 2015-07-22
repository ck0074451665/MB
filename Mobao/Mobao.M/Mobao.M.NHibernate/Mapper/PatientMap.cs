using FluentNHibernate.Mapping;
using Mobao.M.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.NHibernate.Mapper
{
    public class PatientMap : ClassMap<Patient>
    {
        public PatientMap()
        {
            LazyLoad();
            Table("PATIENT");
            Id(d => d.Id).Column("ID");
            Map(m => m.Name).Column("NAME");
            Map(m => m.Brithday).Column("BRITHDAY");
            Map(m => m.Remark).Column("REMARK");
            Map(m => m.Sex).Column("SEX");
        }
    }
}
