using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

class GestorProductos
{
    private readonly string _ruta;
    public List<Producto> Productos { get; } = new();

    public GestorProductos(string rutaCsv)
    {
        _ruta = rutaCsv;
        Cargar();
    }

    public void Cargar()
    {
        Productos.Clear();
        if (!File.Exists(_ruta)) return;
        using var reader = new StreamReader(_ruta);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        var registros = csv.GetRecords<Producto>();
        Productos.AddRange(registros);
    }

    public void Guardar()
    {
        using var writer = new StreamWriter(_ruta);
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csv.WriteRecords(Productos);
    }

    public bool Agregar(Producto producto)
    {
        if (Productos.Exists(p => p.Id == producto.Id)) return false;
        Productos.Add(producto);
        Guardar();
        return true;
    }

    public bool Eliminar(int id)
    {
        var producto = Productos.Find(p => p.Id == id);
        if (producto == null) return false;
        Productos.Remove(producto);
        Guardar();
        return true;
    }
}
