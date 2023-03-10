# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Install .NET SDK
RUN apt-get update && \
    apt-get install -y --no-install-recommends \
        curl \
        gnupg \
        ca-certificates && \
    curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --channel LTS && \
    apt-get remove -y \
        curl \
        gnupg \
        && \
    apt-get clean && \
    rm -rf /var/lib/apt/lists/*

# Copy the project file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the remaining source code and build the application
COPY . ./
RUN dotnet publish -c Release -o out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .

# Expose port and start the application
EXPOSE 80
ENTRYPOINT ["dotnet", "KoolehPooshti.dll"]