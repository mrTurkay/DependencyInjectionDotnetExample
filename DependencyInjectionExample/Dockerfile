FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["DependencyInjectionExample/DependencyInjectionExample.csproj", "DependencyInjectionExample/"]
RUN dotnet restore "DependencyInjectionExample/DependencyInjectionExample.csproj"
COPY . .
WORKDIR "/src/DependencyInjectionExample"
RUN dotnet build "DependencyInjectionExample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DependencyInjectionExample.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DependencyInjectionExample.dll"]
