﻿using Mobao.M.Domain.Domain;
using Mobao.M.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.NHibernate
{
    public class VitalRepository : Repository<Vital>, IVitalRepository
    {
    }
}