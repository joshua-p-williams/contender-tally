FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Contender.Tally.Identity.Admin/Contender.Tally.Identity.Admin.csproj", "src/Contender.Tally.Identity.Admin/"]
COPY ["src/Contender.Tally.Identity.Admin.EntityFramework.Shared/Contender.Tally.Identity.Admin.EntityFramework.Shared.csproj", "src/Contender.Tally.Identity.Admin.EntityFramework.Shared/"]
COPY ["src/Contender.Tally.Identity.Admin.EntityFramework.SqlServer/Contender.Tally.Identity.Admin.EntityFramework.SqlServer.csproj", "src/Contender.Tally.Identity.Admin.EntityFramework.SqlServer/"]
COPY ["src/Contender.Tally.Identity.Admin.EntityFramework.PostgreSQL/Contender.Tally.Identity.Admin.EntityFramework.PostgreSQL.csproj", "src/Contender.Tally.Identity.Admin.EntityFramework.PostgreSQL/"]
COPY ["src/Contender.Tally.Identity.Shared/Contender.Tally.Identity.Shared.csproj", "src/Contender.Tally.Identity.Shared/"]
COPY ["src/Contender.Tally.Identity.Admin.EntityFramework.MySql/Contender.Tally.Identity.Admin.EntityFramework.MySql.csproj", "src/Contender.Tally.Identity.Admin.EntityFramework.MySql/"]
RUN dotnet restore "src/Contender.Tally.Identity.Admin/Contender.Tally.Identity.Admin.csproj"
COPY . .
WORKDIR "/src/src/Contender.Tally.Identity.Admin"
RUN dotnet build "Contender.Tally.Identity.Admin.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Contender.Tally.Identity.Admin.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "Contender.Tally.Identity.Admin.dll"]