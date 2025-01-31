# Usar la imagen base del SDK de .NET para la construcción
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

# Establecer el directorio de trabajo en el contenedor
WORKDIR /app

# Copiar el archivo de solución y restaurar dependencias
COPY ./ServiEntregaHistorical.sln ./
COPY ./Application/Application.csproj ./Application/
COPY ./Infrastructure/Infrastructure.csproj ./Infrastructure/
COPY ./Domain/Domain.csproj ./Domain/
COPY ./Presentation/Presentation.csproj ./Presentation/

RUN dotnet restore ./ServiEntregaHistorical.sln

# Copiar el código fuente y construir la aplicación
COPY ./ ./
RUN dotnet publish ./Presentation/Presentation.csproj -c Release -o /app/publish

# Usar la imagen base del runtime de .NET para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final

WORKDIR /app
COPY --from=build /app/publish .

# Exponer el puerto en el que la API escucha
EXPOSE 80

# Definir el comando para ejecutar la aplicación
ENTRYPOINT ["dotnet", "Presentation.dll"]
