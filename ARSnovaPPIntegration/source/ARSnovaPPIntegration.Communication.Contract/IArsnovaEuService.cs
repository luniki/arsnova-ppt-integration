﻿using ARSnovaPPIntegration.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARSnovaPPIntegration.Communication.Contract
{
    public interface IArsnovaEuService
    {
        SessionModel CreateNewSession();
    }
}