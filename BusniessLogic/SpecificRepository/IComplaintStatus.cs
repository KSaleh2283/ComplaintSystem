﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entity;

namespace BusniessLogic.SpecificRepository
{
    public interface IComplaintStatus
    {
        List<ComplaintStatus> LoadComplaintStatus();
    }
}
