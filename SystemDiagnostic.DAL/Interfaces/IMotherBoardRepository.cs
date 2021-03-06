﻿using System;
using System.Collections.Generic;
using System.Text;
using SystemDiagnostic.Entitites.ComputerComponents;

namespace SystemDiagnostic.DAL.Interfaces
{
    public interface IMotherBoardRepository :IRepository<MotherBoard>
    {
        MotherBoard GetMotherBoardByComputerId(string computerId);
        MotherBoard GetMotherBoardByComputerLogin(string computerLogin);
    }
}
