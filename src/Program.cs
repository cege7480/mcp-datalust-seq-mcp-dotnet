using System;
using ModelContextProtocol;
using Seq.Api;
using Seq.Api.Client;

namespace McpDatalustSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            var mcpServer = new McpServer();
            mcpServer.Start();

            Console.WriteLine("MCP server is running. Press Enter to stop.");
            Console.ReadLine();

            mcpServer.Stop();
        }
    }
}
