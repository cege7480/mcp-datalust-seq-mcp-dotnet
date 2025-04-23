using System;
using System.Threading.Tasks;
using Seq.Api;
using Seq.Api.Client;

namespace McpDatalustSeq
{
    public class SeqApiWrapper
    {
        private readonly SeqConnection _seqConnection;

        public SeqApiWrapper()
        {
            _seqConnection = new SeqConnection("http://localhost:5341");
        }

        public async Task<string> GetEventsAsync()
        {
            var events = await _seqConnection.Events.ListAsync();
            return events.ToString();
        }

        public async Task<string> GetEventAsync(string eventId)
        {
            var seqEvent = await _seqConnection.Events.FindAsync(eventId);
            return seqEvent.ToString();
        }

      
    
    }
}
