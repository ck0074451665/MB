using FluentNHibernate.Mapping;
using Mobao.M.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.NHibernate.Mapper
{
    public class VitalMap : ClassMap<Vital>
    {
        public VitalMap()
        {
            this.LazyLoad();
            Table("Vital");
            Id(i => i.Id).GeneratedBy.Sequence("SQE_TEST").Column("Id");
            Map(m => m.Name).Column("Name");
        }
    }
}
