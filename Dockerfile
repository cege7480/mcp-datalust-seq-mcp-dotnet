# Use the official .NET SDK image as the base image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory
WORKDIR /app

# Copy the project files
COPY src/*.csproj ./src/
COPY tests/*.csproj ./tests/

# Restore the dependencies
RUN dotnet restore src/McpDatalustSeq.csproj
RUN dotnet restore tests/McpDatalustSeq.Tests.csproj

# Copy the remaining files
COPY . .

# Build the project
RUN dotnet build src/McpDatalustSeq.csproj -c Release -o /app/build

# Run the unit and integration tests
RUN dotnet test tests/McpDatalustSeq.Tests.csproj

# Publish the project
RUN dotnet publish src/McpDatalustSeq.csproj -c Release -o /app/publish

# Use the official ASP.NET Core runtime image as the base image for the final stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

# Set the working directory
WORKDIR /app

# Copy the published files from the build stage
COPY --from=build /app/publish .

# Expose the port the application runs on
EXPOSE 80

# Set the entry point for the application
ENTRYPOINT ["dotnet", "McpDatalustSeq.dll"]
