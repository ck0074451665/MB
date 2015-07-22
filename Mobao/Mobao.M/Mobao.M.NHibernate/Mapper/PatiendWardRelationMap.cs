using FluentNHibernate.Mapping;
using Mobao.M.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.NHibernate.Mapper
{
    public class PatiendWardRelationMap : ClassMap<PatientWardRelation>
    {
        public PatiendWardRelationMap()
        {
            LazyLoad();
            Table("PATIENT_WARD_RELATION");
            Id(d => d.Id).Column("ID");
            Map(m => m.PId).Column("PID");
            Map(m => m.WId).Column("WID");
            HasOne<Patient>(h => h.PatientEntity).ForeignKey("P_W_R_PID");
            HasOne<Ward>(w => w.WardEntity).ForeignKey("P_W_R_WID").Cascade.Delete().Fetch.Select();
        }
    }
}
