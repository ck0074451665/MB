using FluentNHibernate.Mapping;
using Mobao.M.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.NHibernate.Mapper
{
    public class WardMap : ClassMap<Ward>
    {
        public WardMap()
        {
            LazyLoad();
            Table("Ward");
            Id(d => d.Id).Column("ID");
            Map(m => m.Name).Column("NAME");
            Map(m => m.Code).Column("CODE");
        }
    }
}
