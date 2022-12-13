FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base 
WORKDIR /app 
EXPOSE 80 
EXPOSE 443 

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build 
WORKDIR /src 
COPY ["Voetbal_User/Voetbal_User.csproj", "Voetbal_User/"] 
RUN dotnet restore "Voetbal_User/Voetbal_User.csproj" 
COPY . . 
WORKDIR "/src/Voetbal_User" 
RUN dotnet build "Voetbal_User.csproj" -c Release -o /app/build 

FROM build AS publish 
RUN dotnet publish "Voetbal_User.csproj" -c Release -o /app/publish /p:UseAppHost=false 

FROM base AS final 
WORKDIR /app 
COPY --from=publish /app/publish . 
ENTRYPOINT ["dotnet", "Voetbal_User.dll"]