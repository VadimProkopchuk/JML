#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["VPX.API/VPX.API.csproj", "VPX.API/"]
COPY ["VPX.BusinessLogic.Core/VPX.BusinessLogic.Core.csproj", "VPX.BusinessLogic.Core/"]
COPY ["VPX.Models/VPX.Models.csproj", "VPX.Models/"]
COPY ["VPX.ApiModels/VPX.ApiModels.csproj", "VPX.ApiModels/"]
COPY ["VPX.Enums/VPX.Enums.csproj", "VPX.Enums/"]
COPY ["VPX.Domain/VPX.Domain.csproj", "VPX.Domain/"]
COPY ["VPX.Domain.Core/VPX.Domain.Core.csproj", "VPX.Domain.Core/"]
COPY ["VPX.DataAccess/VPX.DataAccess.csproj", "VPX.DataAccess/"]
COPY ["VPX.DataAccess.Core/VPX.DataAccess.Core.csproj", "VPX.DataAccess.Core/"]
COPY ["VPX.Utility/VPX.Utility.csproj", "VPX.Utility/"]
COPY ["VPX.BusinessLogic/VPX.BusinessLogic.csproj", "VPX.BusinessLogic/"]
RUN dotnet restore "VPX.API/VPX.API.csproj"
COPY . .
WORKDIR "/src/VPX.API"
RUN dotnet build "VPX.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VPX.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VPX.API.dll"]
