using System;

namespace SystemDiagnostic.Diagnostic.CommandResponseProtocol.CRClient.Interfaces
{
    public interface IClient : IDisposable, IClientMediator
    {
        void Start();
    }
}
