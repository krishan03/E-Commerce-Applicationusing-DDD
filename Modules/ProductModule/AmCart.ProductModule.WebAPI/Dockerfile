FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 51766
EXPOSE 44390

FROM microsoft/dotnet:2.1-sdk-nanoserver-sac2016 AS build
WORKDIR /src
COPY Modules/ProductModule/AmCart.ProductModule.WebAPI/AmCart.ProductModule.WebAPI.csproj Modules/ProductModule/AmCart.ProductModule.WebAPI/
RUN dotnet restore Modules/ProductModule/AmCart.ProductModule.WebAPI/AmCart.ProductModule.WebAPI.csproj
COPY . .
WORKDIR /src/Modules/ProductModule/AmCart.ProductModule.WebAPI
RUN dotnet build AmCart.ProductModule.WebAPI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish AmCart.ProductModule.WebAPI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AmCart.ProductModule.WebAPI.dll"]
