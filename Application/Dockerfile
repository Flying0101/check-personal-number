# Use official .NET runtime as the base image for running the app
FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["check-personal-nr.csproj", "./"]
RUN dotnet restore "./check-personal-nr.csproj"

COPY . .

RUN dotnet publish "./check-personal-nr.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "check-personal-nr.dll"]
``
