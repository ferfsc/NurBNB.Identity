FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app  
EXPOSE 32036  

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NurBNB.Identity.WebAPI/NurBnb.Identity.WebAPI.csproj", "/NurBNB.Identity.WebAPI/"]  
COPY . .
RUN dotnet build "NurBNB.Identity.WebAPI/NurBnb.Identity.WebAPI.csproj" -c Release -o /app  

FROM build AS publish
RUN dotnet publish "NurBNB.Identity.WebAPI/NurBnb.Identity.WebAPI.csproj" -c Release -o /app

#FROM mcr.microsoft.com/dotnet/aspnet:6.0
FROM base AS final
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "NurBnb.Identity.WebAPI.dll"]