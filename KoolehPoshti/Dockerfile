# Define the base image
FROM mcr.microsoft.com/dotnet/aspnet:6.0

# Set the working directory
WORKDIR /app

# Copy the application files
COPY bin/Release/net6.0/publish/ .

# Expose the HTTP port
EXPOSE 80

# Start the application
ENTRYPOINT ["dotnet", "KoolehPoshti.dll"]