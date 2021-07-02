FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Contender.Tally.Identity.STS.Identity/Contender.Tally.Identity.STS.Identity.csproj", "src/Contender.Tally.Identity.STS.Identity/"]
COPY ["src/Contender.Tally.Identity.Admin.EntityFramework.Shared/Contender.Tally.Identity.Admin.EntityFramework.Shared.csproj", "src/Contender.Tally.Identity.Admin.EntityFramework.Shared/"]
COPY ["src/Contender.Tally.Identity.Shared/Contender.Tally.Identity.Shared.csproj", "src/Contender.Tally.Identity.Shared/"]
RUN dotnet restore "src/Contender.Tally.Identity.STS.Identity/Contender.Tally.Identity.STS.Identity.csproj"
COPY . .
WORKDIR "/src/src/Contender.Tally.Identity.STS.Identity"
RUN dotnet build "Contender.Tally.Identity.STS.Identity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Contender.Tally.Identity.STS.Identity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "Contender.Tally.Identity.STS.Identity.dll"]