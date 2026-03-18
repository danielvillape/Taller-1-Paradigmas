using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Tienda de Ropa Deportiva (Mínimo) ===\n");

        var cliente = new Cliente("Ana", "ana@mail.com", "12345678");
        var camiseta = new Ropa(1, "Camiseta", 29.9m, "M", "Rojo");
        var pantalon = new Ropa(2, "Pantalón", 49.5m, "L", "Azul");

        var carrito = new Carrito();
        carrito.Agregar(camiseta);
        carrito.Agregar(pantalon);

        Console.WriteLine("Carrito:");
        foreach (var p in carrito.Productos)
            Console.WriteLine($"- {p}");

        var venta = new Venta(1, cliente);
        venta.AgregarLinea(camiseta, 2);
        venta.AgregarLinea(pantalon, 1);

        Console.WriteLine("\nVenta:");
        Console.WriteLine(venta.ImprimirResumen());

        IImprimible imprimible = venta;
        Console.WriteLine("\nResumen desde IImprimible:");
        Console.WriteLine(imprimible.ImprimirResumen());
    }
}


