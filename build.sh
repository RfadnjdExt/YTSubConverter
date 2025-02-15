#!/bin/bash

# Exit immediately if a command exits with a non-zero status
set -e

# Define the project file
PROJECT_FILE="YTSubConverter.UI.Linux/YTSubConverter.UI.Linux.csproj"

# Clean the solution
echo "Cleaning the solution..."
dotnet clean $PROJECT_FILE

# Restore the solution
echo "Restoring the solution..."
dotnet restore $PROJECT_FILE

# Publish the project
echo "Publishing the project..."
dotnet publish -c Release -r linux-x64 --self-contained false $PROJECT_FILE

echo "Publish completed successfully."