using System;

namespace SystemDiagnostic.Diagnostic.DTO.CommandHandlerEntities
{
    public class ClientResponse
    {
        public int Status {get;set;}
        public string Command {get;set;}
        public string Arguments {get;set;}
    }
}