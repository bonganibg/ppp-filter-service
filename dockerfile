FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /PriceHunterService
COPY . ./
RUN ls
RUN dotnet restore
RUN dotnet publish -c Release -o out
RUN dotnet run

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /PriceHunterService
COPY --from=build-env /PriceHunterService/out .
ENTRYPOINT ["dotnet", "PriceHunterService"]
