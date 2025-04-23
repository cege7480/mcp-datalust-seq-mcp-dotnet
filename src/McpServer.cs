using System;
using System.Threading.Tasks;
using ModelContextProtocol;
using Seq.Api;
using Seq.Api.Client;

namespace McpDatalustSeq
{
    public class McpServer
    {
        private readonly McpServer _mcpServer;
        private readonly SeqApiWrapper _seqApiWrapper;

        public McpServer()
        {
            _mcpServer = new McpServer();
            _seqApiWrapper = new SeqApiWrapper();
        }

        public void Start()
        {
            _mcpServer.Start();
        }

        public void Stop()
        {
            _mcpServer.Stop();
        }

        public async Task<string> GetEventsAsync()
        {
            return await _seqApiWrapper.GetEventsAsync();
        }

        public async Task<string> GetEventAsync(string eventId)
        {
            return await _seqApiWrapper.GetEventAsync(eventId);
        }

 

   
    }
}
