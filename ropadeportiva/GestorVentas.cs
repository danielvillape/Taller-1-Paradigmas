using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

class GestorVentas
{
    private readonly string _ruta;
    public List<VentaCsv> Ventas { get; } = new();

    public GestorVentas(string rutaCsv)
    {
        _ruta = rutaCsv;
        Cargar();
    }

    public void Cargar()
    {
        Ventas.Clear();
        if (!File.Exists(_ruta)) return;
        using var reader = new StreamReader(_ruta);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        var registros = csv.GetRecords<VentaCsv>();
        Ventas.AddRange(registros);
    }

    public void Guardar()
    {
        using var writer = new StreamWriter(_ruta);
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csv.WriteRecords(Ventas);
    }

    public void Agregar(VentaCsv venta)
    {
        Ventas.Add(venta);
        Guardar();
    }
}
