﻿using Mobao.M.Data.Domain;
using Mobao.M.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.Data.Repository
{
    public interface ITestOneRepository : IRepository<TestOne>
    {
        void Init();
    }
}
