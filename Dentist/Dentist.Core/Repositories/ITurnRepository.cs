﻿using Dentist;
using Dentist.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Core.Repositories
{
    public interface ITurnRepository
    {
        public List<turn> getAll();
    }
}
