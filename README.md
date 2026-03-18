# 🧪 Tienda de Ropa Deportiva - Proyecto final

Este proyecto implementa un sistema de consola con paradigmas OOP y persistencia en CSV.

## ✅ Requisitos cubiertos

- Herencia
- Asociación
- Agregación
- Composición
- Interfaz implementada
- Multiplicidad (1:* y 1:1)

## 📁 Estructura final

- `Program.cs` - Demo mínimo de OOP (crear cliente, producto, carrito, venta y resumen)
- `Persona.cs`, `Cliente.cs`, `Producto.cs`, `Ropa.cs`, `Carrito.cs`, `Venta.cs`, `LineaVenta` - modelo orientado a objetos
- `IImprimible.cs` - interfaz implementada por `Venta`

## 🔗 Relaciones OOP implementadas

- Herencia: `Cliente : Persona`, `Ropa : Producto`
- Asociación: `Venta` tiene un `Cliente`
- Agregación: `Carrito` contiene lista de `Producto`
- Composición: `Venta` contiene `LineaVenta`
- Interfaz: `Venta` implementa `IImprimible`

## ▶️ Cómo ejecutar

```bash
cd ropadeportiva
dotnet run
```

Luego usa el menú para:
1) Agregar cliente
2) Agregar producto
3) Registrar venta
4) Ver ventas
5) Salir

## 🧾 Cómo se persisten datos

- Clientes se guardan en `clientes.csv`
- Productos se guardan en `productos.csv`
- Ventas se guardan en `ventas.csv`

## 🧭 Diagrama UML

El diagrama completo está en `ropadeportiva/diagrama-uml.drawio`.

## 🔍 Notas

- El sistema valida entradas básicas y maneja errores de entrada.
- Las ventas se muestran en consola con resumen de líneas.

¡Proyecto listo para entregar! 🎉
