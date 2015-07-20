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
            Table("NURSING_DOC_DATA_REF");
            Id(i => i.PkId).Column("DOC_ID");
            Map(m => m.UserName).Column("PATIENT_ID");
            //  HasMany<SubTestOne>(h => h.SubTest).Table("").KeyColumn("").Fetch.Select();

        }
    }
}
