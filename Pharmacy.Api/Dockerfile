#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Pharmacy.Api/Pharmacy.Api.csproj", "Pharmacy.Api/"]
COPY ["Pharmacy.Application/Pharmacy.Application.csproj", "Pharmacy.Application/"]
COPY ["Pharmacy.Domain/Pharmacy.Domain.csproj", "Pharmacy.Domain/"]
COPY ["Pharmacy.Infrastructure/Pharmacy.Infrastructure.csproj", "Pharmacy.Infrastructure/"]
COPY ["Pharmacy.Utilities/Pharmacy.Utilities.csproj", "Pharmacy.Utilities/"]
RUN dotnet restore "Pharmacy.Api/Pharmacy.Api.csproj"
COPY . .
WORKDIR "/src/Pharmacy.Api"
RUN dotnet build "Pharmacy.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pharmacy.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

RUN ln -fs /usr/share/zoneinfo/America/Lima /etc/localtime
RUN dpkg-reconfigure --frontend noninteractive tzdata

ENTRYPOINT ["dotnet", "Pharmacy.Api.dll"]