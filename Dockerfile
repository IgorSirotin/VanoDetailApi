# Этап сборки
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR .

# Копируем файлы решения и проектов
COPY ["VanoDetailApi.sln", "src/."]
COPY ["src/VanoDetail.Api/VanoDetail.Api.csproj", "src/VanoDetail.Api/"]
COPY ["src/VanoDetail.Application/VanoDetail.Application.csproj", "src/VanoDetail.Application/"]
COPY ["src/VanoDetail.Domain/VanoDetail.Domain.csproj", "VanoDetail.Domain/"]
COPY ["src/VanoDetail.Storage/VanoDetail.Storage.csproj", "VanoDetail.Storage/"]

# Восстанавливаем зависимости
RUN dotnet restore "src/VanoDetailApi.sln"

# Копируем весь исходный код
COPY . .

# Собираем и публикуем решение
RUN dotnet publish "src/VanoDetailApi.sln" -c Release -o /app/publish

# Финальный этап
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Открываем порт и запускаем приложение
EXPOSE 80
EXPOSE 443
ENTRYPOINT ["dotnet", "API.dll"]