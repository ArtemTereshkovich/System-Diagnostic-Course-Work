using System;
using System.Collections.Generic;
using SystemDiagnostic.Diagnostic.Client.WMI.Entities;

namespace SystemDiagnostic.Diagnostic.Client.WMI.Interfaces
{
    public interface IWMIVideoControllerManager
    {
        IEnumerable<WMIVideoController> GetWMIVideoControllers();
    }
}
