# Superheroes API

## Descripción

Superheroes API es un proyecto desarrollado en .NET 8 que permite gestionar la creación y acciones de superhéroes en un contexto de videojuego. El proyecto implementa patrones de diseño como Factory para la creación de superhéroes y Singleton para la gestión de una enfermería con visitas limitadas.

## Tecnologías Utilizadas

* .NET 8

* C#

* Visual Studio

* Swagger para documentación de la API
  
# Estructura del Proyecto

## 1. Carpeta Controllers

SuperheroesController.cs: Maneja los endpoints para crear superhéroes y visitar la enfermería.

## 2. Carpeta Factories

SuperheroeFactory.cs: Implementa el patrón Factory para la creación de diferentes tipos de superhéroes.

## 3. Carpeta Singletons

Enfermeria.cs: Implementa el patrón Singleton para gestionar el límite de visitas a la enfermería.

## 4. Carpeta Models

Superheroe.cs: Clase base que define las propiedades comunes de un superhéroe.

Clases derivadas como Mago, Guerrero, Arquero, etc.

## 5. Carpeta Request

CrearSuperheroeRequest.cs: Clase que define el formato del request para crear un superhéroe.

VisitarEnfermeriaRequest.cs: Clase que define el formato del request para visitar la enfermería.
