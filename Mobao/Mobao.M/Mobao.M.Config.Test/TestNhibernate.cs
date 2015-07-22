using Mobao.M.Domain;
using Mobao.M.Domain;
using Mobao.M.Utility;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobao.M.Config.Test
{
    [Category("nhibernate")]
    [TestFixture]
    public class TestNhibernate
    {
        [Test]
        public void TestConnection()
        {
            Mobao.M.Domain.IRepository<Patient> repo = new Mobao.M.NHibernate.PatientRepository();
            repo.Add(new Patient() { Id = Guid.NewGuid().ToString("N"), Name = "www", Brithday = DateTime.Now, Remark = "", Sex = Sex.Man });
        }


        [Test]
        public void TestLinqQuery()
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
                        select new { PatientId = p.Id, PatientName = p.Name, WardName = w.Name,SexName=SexName };
            foreach (var item in query)
            {
                Console.WriteLine(string.Format("病患：{0},病区:{1}。性别:{2}", item.PatientName, item.WardName,item.SexName));
            }
        }

        public void TestStatisticsWardPatient()
        {

        }
        [Test]
        public void TestAddWard()
        {
            Mobao.M.Domain.IRepository<Ward> repoW = new Mobao.M.NHibernate.WardRepository();
            repoW.Add(new Ward() { Name = "内科", Id = Guid.NewGuid().ToString("N"), Code = "00011001" });
        }
        [Category("NhibrnateInit")]
        [Test]
        public void TestAddRelation()
        {
            Mobao.M.Domain.IRepository<Patient> repoP = new Mobao.M.NHibernate.PatientRepository();
            Mobao.M.Domain.IRepository<Ward> repoW = new Mobao.M.NHibernate.WardRepository();
            Mobao.M.Domain.IRepository<PatientWardRelation> repoRelation =
                new Mobao.M.NHibernate.PatiendWardRelationRepository();

            var patientColl = repoP.GetAll().ToList();
            var wardColl = repoW.GetAll().ToList();
            foreach (var item in patientColl)
            {
                foreach (var item1 in wardColl)
                {
                    repoRelation.Add(new PatientWardRelation() { Id = Guid.NewGuid().ToString("N"), WId = item1.Id, PId = item.Id });
                }
            }
        }

    }
}
