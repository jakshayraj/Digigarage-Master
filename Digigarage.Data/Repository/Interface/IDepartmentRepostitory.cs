﻿using Digigarage.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigarage.Data.Repository.Interface
{
    public interface IDepartmentRepostitory
    {
        IEnumerable<DepartmentViewModel> GetAllDepartment();
    }
}
