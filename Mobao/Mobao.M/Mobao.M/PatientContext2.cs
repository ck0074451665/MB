using Mobao.M.Domain;
using Mobao.M.Interface;
using Mobao.M.Interface.Moudle;
using Mobao.M.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace Mobao.M
{
    [AspNetCompatibilityRequirements()]
    public class PatientContext2 : IPatient
    {
        public List<PatientInfo> GetPatientInfo()
        {
            Mobao.M.Domain.IRepository<Patient> repoP = new Mobao.M.NHibernate.PatientRepository();
            Mobao.M.Domain.IRepository<Ward> repoW = new Mobao.M.NHibernate.WardRepository();
            Mobao.M.Domain.IRepository<PatientWardRelation> repoRelation =
                new Mobao.M.NHibernate.PatiendWardRelationRepository();
            var patientQuery = repoP.GetAll();
            var wQuery = repoW.GetAll();
            var pwRelation = repoRelation.GetAll();
            var query = from p in patientQuery
                        let sexName = p.Sex
                        let SexName = EnumHelper.GetDescription(sexName)
                        join pw in pwRelation on p.Id equals pw.PId
                        join w in wQuery on pw.WId equals w.Id
                        select new PatientInfo { PatientName = p.Name, SexName = SexName, WardName = w.Name };
            return query.ToList();
            //return new List<PatientInfo>();

        }

        public PatientInfo GetPatientInfoEntity()
        {
            //  throw new ArgumentNullException("custome Test");
            Mobao.M.Domain.IRepository<Patient> repoP = new Mobao.M.NHibernate.PatientRepository();
            Mobao.M.Domain.IRepository<Ward> repoW = new Mobao.M.NHibernate.WardRepository();
            Mobao.M.Domain.IRepository<PatientWardRelation> repoRelation =
                new Mobao.M.NHibernate.PatiendWardRelationRepository();
            var patientQuery = repoP.GetAll();
            var wQuery = repoW.GetAll();
            var pwRelation = repoRelation.GetAll();
            var query = from p in patientQuery
                        let sexName = p.Sex
                        let SexName = EnumHelper.GetDescription(sexName)
                        join pw in pwRelation on p.Id equals pw.PId
                        join w in wQuery on pw.WId equals w.Id
                        select new PatientInfo { PatientName = p.Name, SexName = SexName, WardName = w.Name };
            return query.First();
            //return new List<PatientInfo>();

        }

        public string Test()
        {
            return "调用成功!";
        }
    }
}
