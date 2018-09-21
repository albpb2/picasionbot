FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["PicasionBot/PicasionBot.csproj", "PicasionBot/"]
RUN dotnet restore "PicasionBot/PicasionBot.csproj"
COPY . .
WORKDIR "/src/PicasionBot"
RUN dotnet build "PicasionBot.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "PicasionBot.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "PicasionBot.dll"]