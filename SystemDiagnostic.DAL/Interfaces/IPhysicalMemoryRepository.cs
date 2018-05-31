﻿using System;
using System.Collections.Generic;
using System.Text;
using SystemDiagnostic.Entitites.ComputerComponents;

namespace SystemDiagnostic.DAL.Interfaces
{
    public interface IPhysicalMemoryRepository :IRepository<PhysicalMemory>
    {
        IEnumerable<PhysicalMemory> GetPhysicalMemoriesByProcessId(string processId);
    }
}