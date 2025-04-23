# mcp-datalust-seq-mcp-dotnet
Datalust Seq Server API wrapped as an MCP

## Instructions

### How to use the MCP in dotnet that wraps the Datalust Seq API

1. Clone the repository:
   ```sh
   git clone https://github.com/cege7480/mcp-datalust-seq-mcp-dotnet.git
   cd mcp-datalust-seq-mcp-dotnet
   ```

2. Build the project:
   ```sh
   dotnet build
   ```

3. Run the MCP server:
   ```sh
   dotnet run --project src/McpDatalustSeq.csproj
   ```

### How to run the unit tests

1. Build the test project:
   ```sh
   dotnet build tests/McpDatalustSeq.Tests.csproj
   ```

2. Run the tests:
   ```sh
   dotnet test tests/McpDatalustSeq.Tests.csproj
   ```

### How to build and publish the Docker container to `ghcr.io`

1. Build the Docker image:
   ```sh
   docker build -t ghcr.io/<your-username>/mcp-datalust-seq-mcp-dotnet:latest .
   ```

2. Push the Docker image to `ghcr.io`:
   ```sh
   docker push ghcr.io/<your-username>/mcp-datalust-seq-mcp-dotnet:latest
   ```

## References

- [Datalust Seq API](https://github.com/cege7480/seq-api)
- [Model Context Protocol (MCP) SDK](https://modelcontextprotocol.github.io/csharp-sdk/api/ModelContextProtocol.html)
- [Building a Model Context Protocol (MCP) Server in C#](https://devblogs.microsoft.com/dotnet/build-a-model-context-protocol-mcp-server-in-csharp/)
