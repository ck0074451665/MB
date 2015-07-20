using Mobao.M.Domain;
using Mobao.M.Interface;
using Mobao.M.Interface.Moudle;
using Mobao.M.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M
{
    public class Service1 : IService1
    {
        private Mobao.M.Domain.IRepository<TestOne> _repository;

        public Service1()
        {
            _repository = new TestOneRepository();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {

            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void TestAdd()
        {


        }
    }
}
