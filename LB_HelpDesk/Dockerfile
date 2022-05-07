#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LB_HelpDesk/LB_HelpDesk.csproj", "LB_HelpDesk/"]
RUN dotnet restore "LB_HelpDesk/LB_HelpDesk.csproj"
COPY . .
WORKDIR "/src/LB_HelpDesk"
RUN dotnet build "LB_HelpDesk.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LB_HelpDesk.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LB_HelpDesk.dll"]