# 🏪 Tienda de Ropa Deportiva - Sistema CRUD

## 📋 ¿Qué es esto?

Un sistema de gestión para una tienda de ropa deportiva que permite:
- ✅ Agregar, ver, actualizar y eliminar **productos**
- ✅ Agregar, ver, actualizar y eliminar **clientes**
- ✅ Registrar y eliminar **ventas**
- ✅ Control automático de **stock**

Los datos se guardan en archivos **CSV** (no necesitas una base de datos compleja).

---

## � Requisitos

- **.NET 8 SDK** instalado
- **Git** para versión control

---

## 📁 Estructura

```
ropadeportiva/
├── Producto.cs          # Modelo de producto
├── Cliente.cs           # Modelo de cliente
├── Venta.cs             # Modelo de venta
├── GestorProductos.cs   # CRUD de productos
├── GestorClientes.cs    # CRUD de clientes
├── GestorVentas.cs      # CRUD de ventas
├── Program.cs           # Menú principal
├── Productos.csv        # Base de datos (se crea automáticamente)
├── Clientes.csv         # Base de datos (se crea automáticamente)
└── Ventas.csv           # Base de datos (se crea automáticamente)
```

---

## ▶️ Cómo usar

### 1. Ejecutar la aplicación

```bash
cd ropadeportiva/ropadeportiva
dotnet run
```

### 2. Menú principal

```
========================================
  TIENDA DE ROPA DEPORTIVA
========================================
1. Gestionar Productos
2. Gestionar Clientes
3. Gestionar Ventas
4. Salir
```

Selecciona un número y sigue las instrucciones.

---

## 🎯 ¿Cómo funciona cada parte?

### Productos
- **ID**: Identificador único (ej: 1, 2, 3)
- **Nombre**: Nombre de la prenda (ej: "Camiseta Nike")
- **Talla**: XS, S, M, L, XL, XXL
- **Precio**: Valor unitario (ej: 49.99)
- **Stock**: Cantidad disponible

### Clientes
- **ID**: Identificador único
- **Nombre**: Nombre completo
- **Email**: Correo electrónico
- **Teléfono**: Número de contacto

### Ventas
- **ID**: Identificador único
- **Cliente**: ID del cliente que compró
- **Producto**: ID del producto vendido
- **Cantidad**: Unidades vendidas
- **Fecha**: Cuándo se realizó la venta

---

## 💾 CSV Helper

La librería **CsvHelper** simplifica trabajar con archivos CSV:

- **Cargar**: Lee el CSV y convierte las filas en objetos
- **Guardar**: Toma la lista de objetos y escribe en el CSV

Así no tienes que parsear strings manualmente.

---

## 🔍 Ejemplo: Registrar una venta

```
1. Ir a "Gestionar Ventas" → "Registrar nueva venta"
2. Ingresar ID de la venta (ej: 1)
3. Ingresar ID del cliente (ej: 1)
4. Ingresar ID del producto (ej: 2)
5. Ingresar cantidad (ej: 2)

Resultado:
✓ Venta registrada
✓ Stock del producto se reduce automáticamente
✓ Datos guardados en Ventas.csv
```

---

## ⚙️ Compilar y probar

```bash
# Descargar dependencias
dotnet restore

# Compilar
dotnet build

# Ejecutar
dotnet run
```

---

## 📝 Notas importantes

- Los archivos CSV se crean automáticamente la primera vez que ejecutas la app
- Cada cambio (agregar, actualizar, eliminar) se guarda **inmediatamente**
- Si cierras la app, los datos se mantienen (están en los CSV)
- La app valida que:
  - No haya IDs duplicados
  - Los clientes y productos existan antes de vender
  - Haya stock suficiente para cada venta

---

## 🎓 Lo que aprendes aquí

- Clases y objetos (POO)
- Listas y LINQ
- Lectura/escritura de archivos
- Patrón CRUD
- Menús interactivos en consola
- Persistencia de datos

---

¡Listo! Ahora a usar el sistema 🚀
