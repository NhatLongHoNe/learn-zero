#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Asd.AbpZeroTemplate.Migrator/Asd.AbpZeroTemplate.Migrator.csproj", "src/Asd.AbpZeroTemplate.Migrator/"]
COPY ["src/Asd.AbpZeroTemplate.EntityFrameworkCore/Asd.AbpZeroTemplate.EntityFrameworkCore.csproj", "src/Asd.AbpZeroTemplate.EntityFrameworkCore/"]
COPY ["src/Asd.AbpZeroTemplate.Core/Asd.AbpZeroTemplate.Core.csproj", "src/Asd.AbpZeroTemplate.Core/"]
COPY ["src/Asd.AbpZeroTemplate.Core.Shared/Asd.AbpZeroTemplate.Core.Shared.csproj", "src/Asd.AbpZeroTemplate.Core.Shared/"]
RUN dotnet restore "src/Asd.AbpZeroTemplate.Migrator/Asd.AbpZeroTemplate.Migrator.csproj"
COPY . .
WORKDIR "/src/src/Asd.AbpZeroTemplate.Migrator"
RUN dotnet build "Asd.AbpZeroTemplate.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Asd.AbpZeroTemplate.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Asd.AbpZeroTemplate.Migrator.dll"]
