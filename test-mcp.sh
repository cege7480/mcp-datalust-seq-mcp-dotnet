#!/bin/bash

# Build the MCP server
dotnet build src/McpDatalustSeq.csproj

# Run the unit and integration tests
dotnet test tests/McpDatalustSeq.Tests.csproj
