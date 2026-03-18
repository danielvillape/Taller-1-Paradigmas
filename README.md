# Sistema de Gestión de Ropa Deportiva

## Descripción
Aplicación console en C# para gestionar tiendas de ropa deportiva. Permite administrar clientes, productos y ventas con persistencia en archivos CSV.

## Estructura del Proyecto

```
ropadeportiva/
├── Entidad.cs           (Clase base abstracta)
├── Cliente.cs           (Hereda de Entidad)
├── Producto.cs          (Hereda de Entidad)
├── Venta.cs
├── GestorClientes.cs
├── GestorProductos.cs
├── GestorVentas.cs
├── Program.cs
└── ropadeportiva.csproj
```

## Clases Principales

### Entidad (Clase base)
Clase abstracta que proporciona funcionalidad común para Cliente y Producto.
- **Atributos**: `id`, `nombre`
- **Métodos**: `GetId()`, `GetNombre()`, `ToString()`

### Cliente (Hereda de Entidad)
Representa un cliente del sistema.
- **Atributos adicionales**: `email`, `telefono`
- **Métodos**: `GetEmail()`, `GetTelefono()`

### Producto (Hereda de Entidad)
Representa un producto disponible.
- **Atributos adicionales**: `talla`, `precio`, `cantidadStock`
- **Métodos**: `GetTalla()`, `GetPrecio()`, `GetCantidadStock()`, `SetCantidadStock()`

### Venta
Representa una transacción de venta.
- **Atributos**: `id`, `clienteId`, `productoId`, `cantidad`, `fecha`
- **Métodos**: Getters para acceder a los datos

## Relaciones

```
Entidad (clase base abstracta)
  ├── Cliente (herencia)
  └── Producto (herencia)

Venta
  ├── Asociación con Cliente (por clienteId)
  └── Asociación con Producto (por productoId)
```

## Funcionalidades

- ✅ **Gestión de Clientes**: Crear, listar y buscar clientes
- ✅ **Gestión de Productos**: Crear, listar, buscar y actualizar stock
- ✅ **Gestión de Ventas**: Registrar y listar ventas
- ✅ **Persistencia**: Datos guardados en archivos CSV
- ✅ **Herencia**: Cliente y Producto heredan de Entidad

## Cómo usar

1. Ejecuta la aplicación desde la línea de comandos
2. Selecciona la opción deseada del menú
3. Sigue las instrucciones en pantalla
4. Los datos se guardan automáticamente en archivos CSV

## Requisitos

- .NET 8.0 o superior
- Visual Studio o VS Code con extensión de C#
