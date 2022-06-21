#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Asd.AbpZeroTemplate.Web.Host/Asd.AbpZeroTemplate.Web.Host.csproj", "src/Asd.AbpZeroTemplate.Web.Host/"]
COPY ["src/Asd.AbpZeroTemplate.Web.Core/Asd.AbpZeroTemplate.Web.Core.csproj", "src/Asd.AbpZeroTemplate.Web.Core/"]
COPY ["src/Asd.AbpZeroTemplate.Application/Asd.AbpZeroTemplate.Application.csproj", "src/Asd.AbpZeroTemplate.Application/"]
COPY ["src/Asd.AbpZeroTemplate.Application.Shared/Asd.AbpZeroTemplate.Application.Shared.csproj", "src/Asd.AbpZeroTemplate.Application.Shared/"]
COPY ["src/Asd.AbpZeroTemplate.Core.Shared/Asd.AbpZeroTemplate.Core.Shared.csproj", "src/Asd.AbpZeroTemplate.Core.Shared/"]
COPY ["src/Asd.AbpZeroTemplate.Core/Asd.AbpZeroTemplate.Core.csproj", "src/Asd.AbpZeroTemplate.Core/"]
COPY ["src/Asd.AbpZeroTemplate.EntityFrameworkCore/Asd.AbpZeroTemplate.EntityFrameworkCore.csproj", "src/Asd.AbpZeroTemplate.EntityFrameworkCore/"]
COPY ["src/Asd.AbpZeroTemplate.GraphQL/Asd.AbpZeroTemplate.GraphQL.csproj", "src/Asd.AbpZeroTemplate.GraphQL/"]
RUN dotnet restore "src/Asd.AbpZeroTemplate.Web.Host/Asd.AbpZeroTemplate.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/Asd.AbpZeroTemplate.Web.Host"
RUN dotnet build "Asd.AbpZeroTemplate.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Asd.AbpZeroTemplate.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Asd.AbpZeroTemplate.Web.Host.dll"]
