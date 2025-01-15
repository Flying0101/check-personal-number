# Use official .NET runtime as the base image for running the app
FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["Application/check-personal-nr.csproj", "Application/"]
RUN dotnet restore "Application/check-personal-nr.csproj"
COPY . .
RUN dotnet publish "Application/check-personal-nr.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "check-personal-nr.dll"]