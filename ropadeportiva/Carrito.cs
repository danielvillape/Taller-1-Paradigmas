using System.Collections.Generic;
using System.Linq;

class Carrito
{
    private readonly List<Producto> _productos = new();
    public IReadOnlyList<Producto> Productos => _productos.AsReadOnly();

    public void Agregar(Producto producto) => _productos.Add(producto);
    public decimal Total() => _productos.Sum(p => p.Precio);
}
