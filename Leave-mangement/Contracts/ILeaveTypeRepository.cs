﻿using Leave_mangement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_mangement.Contracts
{
    public interface ILeaveTypeRepository:IRepositoryBase<LeaveType>
    {

        ICollection<LeaveType> GetEmployeesLeaveType(int ID);

    }
}
