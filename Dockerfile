#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

USER root
RUN apt-get update \
    && apt-get install -y --no-install-recommends \
    libc6 libicu-dev libfontconfig1 sudo


FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["DXApplication2.Blazor.Server/DXApplication2.Blazor.Server.csproj", "DXApplication2.Blazor.Server/"]
COPY ["DXApplication2.Blazor.Server/mydatabase.xml", "DXApplication2.Blazor.Server/"]
COPY ["DXApplication2.Module/DXApplication2.Module.csproj", "DXApplication2.Module/"]
COPY ["nuget.config", "nuget.config"]
RUN dotnet restore "./DXApplication2.Blazor.Server/./DXApplication2.Blazor.Server.csproj"
COPY . .
WORKDIR "/src/DXApplication2.Blazor.Server"
RUN dotnet build "./DXApplication2.Blazor.Server.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./DXApplication2.Blazor.Server.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DXApplication2.Blazor.Server.dll"]