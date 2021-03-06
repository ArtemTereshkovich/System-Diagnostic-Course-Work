using System;
using System.Net;
using SystemDiagnostic.Diagnostic.CommandResponseProtocol.CRServer.Entities;
using SystemDiagnostic.Diagnostic.CommandResponseProtocol.Entities;

namespace SystemDiagnostic.Diagnostic.CommandResponseProtocol.CRServer.Interfaces
{
    public interface IServer
    {
        void Run(IPAddress iPAddress, int port,int countClients);
        void Run(RunPropertyModel runPropertyModel);
    }
}
