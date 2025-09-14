# Сборка приложения
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Копируем и восстанавливаем зависимости
COPY ["VanoDetail.Domain/VanoDetail.Domain.csproj", "VanoDetail.Domain/"]
COPY ["VanoDetail.Application/VanoDetail.Application.csproj", "VanoDetail.Application/"]
COPY ["VanoDetail.Storage/VanoDetail.Storage.csproj", "VanoDetail.Storage/"]
COPY ["VanoDetail.Api/VanoDetail.Api.csproj", "VanoDetail.Api/"]
COPY ["VanoDetail.Migrations/VanoDetail.Migrations.csproj", "VanoDetail.Migrations/"]
RUN dotnet restore "VanoDetail.Api/VanoDetail.Api.csproj"

# Копируем и публикуем приложение
COPY . .
RUN dotnet publish "VanoDetail.Api/VanoDetail.Api.csproj" -c Release -o /app

# Финальный образ
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app .

# Запуск приложения
CMD ["./VanoDetail.Api"]