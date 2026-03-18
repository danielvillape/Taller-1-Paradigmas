using System;
using System.Collections.Generic;
using System.Linq;

class Venta : IImprimible
{
    public int Id { get; }
    public Cliente Cliente { get; }
    public DateTime Fecha { get; }
    private readonly List<LineaVenta> _lineas;

    public Venta(int id, Cliente cliente)
    {
        Id = id;
        Cliente = cliente;
        Fecha = DateTime.Now;
        _lineas = new List<LineaVenta>();
    }

    public IReadOnlyList<LineaVenta> Lineas => _lineas.AsReadOnly();

    public void AgregarLinea(Producto producto, int cantidad)
    {
        if (cantidad <= 0) throw new ArgumentException("Cantidad debe ser mayor que cero.");
        _lineas.Add(new LineaVenta(producto, cantidad));
    }

    public decimal TotalVenta() => _lineas.Sum(l => l.Subtotal);

    public string ImprimirResumen()
    {
        var texto = $"Venta #{Id}\nCliente: {Cliente.Nombre}\nFecha: {Fecha:g}\n";
        foreach (var linea in _lineas)
            texto += $" - {linea.Producto.Nombre} x{linea.Cantidad} = ${linea.Subtotal:0.00}\n";
        texto += $"Total: ${TotalVenta():0.00}";
        return texto;
    }

    public class LineaVenta
    {
        public Producto Producto { get; }
        public int Cantidad { get; }
        public decimal Subtotal => Producto.Precio * Cantidad;

        public LineaVenta(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }
    }
}
