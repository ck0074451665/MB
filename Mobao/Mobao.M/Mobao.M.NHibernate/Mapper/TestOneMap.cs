using FluentNHibernate.Mapping;
using Mobao.M.Domain;
using Mobao.M.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.NHibernate.Mapper
{
    public class TestOneMap : ClassMap<TestOne>
    {
        public TestOneMap()
        {
            this.LazyLoad();
            Table("");
            Id(i => i.ToString());
            Map(m => m.ToString());
            HasMany<SubTestOne>(h => h.SubTest).Table("").KeyColumn("").Fetch.Select();

        }
    }
}
