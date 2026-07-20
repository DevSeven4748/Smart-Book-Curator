# ---- Build stage ----
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy only the .csproj files first (better Docker layer caching)
COPY BookCurator.DAL/BookCurator.DAL.csproj BookCurator.DAL/
COPY BookCurator.BLL/BookCurator.BLL.csproj BookCurator.BLL/
COPY BookCurator.MVC/BookCurator.MVC.csproj BookCurator.MVC/

RUN dotnet restore BookCurator.MVC/BookCurator.MVC.csproj

# Now copy everything else and publish
COPY . .
WORKDIR /src/BookCurator.MVC
RUN dotnet publish -c Release -o /app/publish

# ---- Runtime stage ----
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Render assigns a port dynamically via $PORT — bind to it at container start
ENTRYPOINT ["sh", "-c", "ASPNETCORE_URLS=http://+:$PORT dotnet BookCurator.MVC.dll"]