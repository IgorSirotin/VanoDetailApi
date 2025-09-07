# Этап сборки
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Копируем файлы проекта и восстанавливаем зависимости
COPY ["VanoDetail.Api.csproj", "."]
RUN dotnet restore "VanoDetail.Api.csproj"

# Копируем всё и собираем проект
COPY . .
RUN dotnet publish -c release -o /app --no-restore

# Финальный этап
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app .

# Открываем порт и запускаем приложение
EXPOSE 80
ENTRYPOINT ["dotnet", "VanoDetail.Api.dll"]